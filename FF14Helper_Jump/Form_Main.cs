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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private bool hookEnabled = true;
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
            RunAsync(() =>
            {
                RunAsync(() => SendLongPress(87, 170));
                Sleep(130);
                RunAsync(() => SendLongPress(32, 90));
            });
        }

        private void JumpKeyP3()
        {
            RunAsync(() =>
            {
                RunAsync(() => SendLongPress(87, 90));
                Sleep(50);
                RunAsync(() => SendLongPress(32, 50));
            });
        }

        private void JumpKeyP1()
        {
            RunAsync(() =>
            {
                RunAsync(() => SendLongPress(32, 90));
                Win32KeyDown(32);
                Sleep(30);
                RunAsync(() => SendLongPress(87, 80));
                Sleep(20);
                Win32KeyUp(32);
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
    }
    
}
