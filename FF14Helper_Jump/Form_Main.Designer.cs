namespace FF14Helper_Jump
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Text_KeyP5 = new System.Windows.Forms.TextBox();
            this.Text_KeyP3 = new System.Windows.Forms.TextBox();
            this.Text_KeyP1 = new System.Windows.Forms.TextBox();
            this.Lab_KeyP5 = new System.Windows.Forms.Label();
            this.Lab_KeyP3 = new System.Windows.Forms.Label();
            this.Lab_KeyP1 = new System.Windows.Forms.Label();
            this.Btn_SetKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_KeyP5
            // 
            this.Text_KeyP5.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_KeyP5.Location = new System.Drawing.Point(97, 16);
            this.Text_KeyP5.Name = "Text_KeyP5";
            this.Text_KeyP5.Size = new System.Drawing.Size(60, 41);
            this.Text_KeyP5.TabIndex = 5;
            this.Text_KeyP5.Text = "Q";
            this.Text_KeyP5.Enter += new System.EventHandler(this.Text_KeyBind_Enter);
            this.Text_KeyP5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_KeyBind_KeyDown);
            this.Text_KeyP5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyBind_KeyPress);
            this.Text_KeyP5.Leave += new System.EventHandler(this.Text_KeyBind_Leave);
            // 
            // Text_KeyP3
            // 
            this.Text_KeyP3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_KeyP3.Location = new System.Drawing.Point(97, 63);
            this.Text_KeyP3.Name = "Text_KeyP3";
            this.Text_KeyP3.Size = new System.Drawing.Size(60, 41);
            this.Text_KeyP3.TabIndex = 6;
            this.Text_KeyP3.Text = "E";
            this.Text_KeyP3.Enter += new System.EventHandler(this.Text_KeyBind_Enter);
            this.Text_KeyP3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_KeyBind_KeyDown);
            this.Text_KeyP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyBind_KeyPress);
            this.Text_KeyP3.Leave += new System.EventHandler(this.Text_KeyBind_Leave);
            // 
            // Text_KeyP1
            // 
            this.Text_KeyP1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_KeyP1.Location = new System.Drawing.Point(97, 111);
            this.Text_KeyP1.Name = "Text_KeyP1";
            this.Text_KeyP1.Size = new System.Drawing.Size(60, 41);
            this.Text_KeyP1.TabIndex = 7;
            this.Text_KeyP1.Text = "R";
            this.Text_KeyP1.Enter += new System.EventHandler(this.Text_KeyBind_Enter);
            this.Text_KeyP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_KeyBind_KeyDown);
            this.Text_KeyP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyBind_KeyPress);
            this.Text_KeyP1.Leave += new System.EventHandler(this.Text_KeyBind_Leave);
            // 
            // Lab_KeyP5
            // 
            this.Lab_KeyP5.AutoSize = true;
            this.Lab_KeyP5.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_KeyP5.Location = new System.Drawing.Point(12, 18);
            this.Lab_KeyP5.Name = "Lab_KeyP5";
            this.Lab_KeyP5.Size = new System.Drawing.Size(79, 33);
            this.Lab_KeyP5.TabIndex = 1;
            this.Lab_KeyP5.Text = "大跳";
            // 
            // Lab_KeyP3
            // 
            this.Lab_KeyP3.AutoSize = true;
            this.Lab_KeyP3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_KeyP3.Location = new System.Drawing.Point(12, 65);
            this.Lab_KeyP3.Name = "Lab_KeyP3";
            this.Lab_KeyP3.Size = new System.Drawing.Size(79, 33);
            this.Lab_KeyP3.TabIndex = 1;
            this.Lab_KeyP3.Text = "小跳";
            // 
            // Lab_KeyP1
            // 
            this.Lab_KeyP1.AutoSize = true;
            this.Lab_KeyP1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_KeyP1.Location = new System.Drawing.Point(12, 113);
            this.Lab_KeyP1.Name = "Lab_KeyP1";
            this.Lab_KeyP1.Size = new System.Drawing.Size(79, 33);
            this.Lab_KeyP1.TabIndex = 1;
            this.Lab_KeyP1.Text = "微跳";
            // 
            // Btn_SetKey
            // 
            this.Btn_SetKey.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SetKey.Location = new System.Drawing.Point(175, 16);
            this.Btn_SetKey.Name = "Btn_SetKey";
            this.Btn_SetKey.Size = new System.Drawing.Size(146, 136);
            this.Btn_SetKey.TabIndex = 0;
            this.Btn_SetKey.Text = "设置\r\n按键";
            this.Btn_SetKey.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 166);
            this.Controls.Add(this.Btn_SetKey);
            this.Controls.Add(this.Lab_KeyP1);
            this.Controls.Add(this.Lab_KeyP3);
            this.Controls.Add(this.Lab_KeyP5);
            this.Controls.Add(this.Text_KeyP1);
            this.Controls.Add(this.Text_KeyP3);
            this.Controls.Add(this.Text_KeyP5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "FF14Helper 跳跳乐";
            this.Deactivate += new System.EventHandler(this.Form_Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_KeyP5;
        private System.Windows.Forms.TextBox Text_KeyP3;
        private System.Windows.Forms.TextBox Text_KeyP1;
        private System.Windows.Forms.Label Lab_KeyP5;
        private System.Windows.Forms.Label Lab_KeyP3;
        private System.Windows.Forms.Label Lab_KeyP1;
        private System.Windows.Forms.Button Btn_SetKey;
    }
}

