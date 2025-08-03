using FF14Helper_Jump.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FF14Helper_Jump
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool hookEnabled = false;
        private DateTime hookKeyPressTime = DateTime.Now;
        private const float keyPressInterval = 200;

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hook.HookClear();
            Environment.Exit(0);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Hook.HookRestart(ListenKey);

            try
            {
                Text_KeyP1.Text = (Keys)Settings.Default.KeyP1 + "";
                Text_KeyP3.Text = (Keys)Settings.Default.KeyP3 + "";
                Text_KeyP5.Text = (Keys)Settings.Default.KeyP5 + "";
                Text_KeyW.Text = (Keys)Settings.Default.KeyW + "";
                Text_KeySpace.Text = (Keys)Settings.Default.KeySpace + "";

                Text_P5W.Text = Settings.Default.P5W + "";
                Text_P3W.Text = Settings.Default.P3W + "";
                Text_P1W.Text = Settings.Default.P1W + "";
                Text_P5D.Text = Settings.Default.P5D + "";
                Text_P3D.Text = Settings.Default.P3D + "";
                Text_P1D.Text = Settings.Default.P1D + "";
                Text_P5S.Text = Settings.Default.P5S + "";
                Text_P3S.Text = Settings.Default.P3S + "";
                Text_P1S.Text = Settings.Default.P1S + "";
            }
            catch
            {
                MessageBox.Show("数据读取有误, 请重新保存");
            }
        }

        private void ListenKey(Keys k)
        {
            try
            {
                if (!hookEnabled) return;
                if ((DateTime.Now - hookKeyPressTime).TotalMilliseconds < keyPressInterval) return;
                hookKeyPressTime = DateTime.Now;

                if ((int)k == Settings.Default.KeyP5)
                {
                    JumpKeyP5();
                    return;
                }
                if ((int)k == Settings.Default.KeyP3)
                {
                    JumpKeyP3();
                    return;
                }
                if ((int)k == Settings.Default.KeyP1)
                {
                    JumpKeyP1();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                Environment.Exit(0);
            }
        }


        private void JumpKeyP5()
        {
            //红莲节 4.5块木板

            var w = Settings.Default.P5W;
            var d = Settings.Default.P5D;
            var s = Settings.Default.P5S;

            var keyW = Settings.Default.KeyW;
            var keySpace = Settings.Default.KeySpace;

            RunAsync(() =>
            {
                RunAsync(() => SendLongPress((byte)keyW, w));
                Sleep(d);
                RunAsync(() => SendLongPress((byte)keySpace, s));
            });


        }

        private void JumpKeyP3()
        {
            //红莲节 3.5块木板


            var w = Settings.Default.P3W;
            var d = Settings.Default.P3D;
            var s = Settings.Default.P3S;

            var keyW = Settings.Default.KeyW;
            var keySpace = Settings.Default.KeySpace;

            RunAsync(() =>
            {
                RunAsync(() => SendLongPress((byte)keyW, w));
                Sleep(d);
                RunAsync(() => SendLongPress((byte)keySpace, s));
            });

        }

        private void JumpKeyP1()
        {
            //红莲节 2块木板

            //RunAsync(() =>
            //{
            //    RunAsync(() => SendLongPress(87, 140));
            //    Sleep(10);
            //    RunAsync(() => SendLongPress(32, 80));
            //});

            var w = Settings.Default.P1W;
            var d = Settings.Default.P1D;
            var s = Settings.Default.P1S;

            var keyW = Settings.Default.KeyW;
            var keySpace = Settings.Default.KeySpace;

            RunAsync(() =>
            {
                RunAsync(() => SendLongPress((byte)keyW, w));
                Sleep(d);
                RunAsync(() => SendLongPress((byte)keySpace, s));
            });
        }

        private void SendLongPress(byte key, int ms)
        {
            DateTime now = DateTime.Now;
            while ((DateTime.Now - now).TotalMilliseconds < ms)
            {
                Win32KeyDown(key);
                Thread.Sleep(1);
            }
            Win32KeyUp(key);
        }

        private void RunAsync(Action action)
        {
            new Thread(new ThreadStart(action)).Start();
        }

        private void Sleep(int ms)
        {
            Thread.Sleep(ms);
        }

        private void Win32KeyDown(byte key)
        {
            Win32API.keybd_event(key, 0, 0, 0);
        }

        private void Win32KeyUp(byte key)
        {
            Win32API.keybd_event(key, 0, 2, 0);
        }

        private void Text_KeyBind_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textKeyBind = sender as TextBox;
            textKeyBind.Text = e.KeyCode.ToString();
        }

        private void Text_KeyBind_Enter(object sender, EventArgs e)
        {
            hookEnabled = false;
        }

        private void Text_KeyBind_Leave(object sender, EventArgs e)
        {
            hookEnabled = true;
        }

        private void Text_KeyBind_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form_Main_Deactivate(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.KeyP1 = (int)Enum.Parse(typeof(Keys), Text_KeyP1.Text);
                Settings.Default.KeyP3 = (int)Enum.Parse(typeof(Keys), Text_KeyP3.Text);
                Settings.Default.KeyP5 = (int)Enum.Parse(typeof(Keys), Text_KeyP5.Text);

                Settings.Default.KeyW = (int)Enum.Parse(typeof(Keys), Text_KeyW.Text);
                Settings.Default.KeySpace = (int)Enum.Parse(typeof(Keys), Text_KeySpace.Text);

                Settings.Default.P5W = int.Parse(Text_P5W.Text);
                Settings.Default.P3W = int.Parse(Text_P3W.Text);
                Settings.Default.P1W = int.Parse(Text_P1W.Text);

                Settings.Default.P5D = int.Parse(Text_P5D.Text);
                Settings.Default.P3D = int.Parse(Text_P3D.Text);
                Settings.Default.P1D = int.Parse(Text_P1D.Text);

                Settings.Default.P5S = int.Parse(Text_P5S.Text);
                Settings.Default.P3S = int.Parse(Text_P3S.Text);
                Settings.Default.P1S = int.Parse(Text_P1S.Text);

                Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("输入有问题\n建议重修封闭圣塔黎铎拉纳大灯塔Boss3劳动七号");
            }
        }

        private void checkBoxEnable_CheckedChanged(object sender, EventArgs e)
        {
            hookEnabled = checkBoxEnable.Checked;
        }
    }

}
