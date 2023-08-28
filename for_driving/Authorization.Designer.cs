namespace for_driving
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.login_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.reg_b = new MaterialSkin.Controls.MaterialFlatButton();
            this.pass_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.log_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkPass = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // login_b
            // 
            this.login_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_b.Depth = 0;
            this.login_b.Location = new System.Drawing.Point(184, 251);
            this.login_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_b.Name = "login_b";
            this.login_b.Primary = true;
            this.login_b.Size = new System.Drawing.Size(111, 39);
            this.login_b.TabIndex = 12;
            this.login_b.Text = "Авторизация";
            this.login_b.UseVisualStyleBackColor = true;
            this.login_b.Click += new System.EventHandler(this.Login_b_Click);
            // 
            // reg_b
            // 
            this.reg_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reg_b.AutoSize = true;
            this.reg_b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reg_b.Depth = 0;
            this.reg_b.Location = new System.Drawing.Point(184, 299);
            this.reg_b.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reg_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.reg_b.Name = "reg_b";
            this.reg_b.Primary = false;
            this.reg_b.Size = new System.Drawing.Size(110, 36);
            this.reg_b.TabIndex = 11;
            this.reg_b.Text = "Регистрация";
            this.reg_b.UseVisualStyleBackColor = true;
            this.reg_b.Click += new System.EventHandler(this.Reg_b_Click_1);
            // 
            // pass_tb
            // 
            this.pass_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_tb.Depth = 0;
            this.pass_tb.Hint = "";
            this.pass_tb.Location = new System.Drawing.Point(182, 203);
            this.pass_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.PasswordChar = '\0';
            this.pass_tb.SelectedText = "";
            this.pass_tb.SelectionLength = 0;
            this.pass_tb.SelectionStart = 0;
            this.pass_tb.Size = new System.Drawing.Size(111, 23);
            this.pass_tb.TabIndex = 10;
            this.pass_tb.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(180, 172);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Пароль";
            // 
            // log_tb
            // 
            this.log_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_tb.Depth = 0;
            this.log_tb.Hint = "";
            this.log_tb.Location = new System.Drawing.Point(182, 135);
            this.log_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.log_tb.Name = "log_tb";
            this.log_tb.PasswordChar = '\0';
            this.log_tb.SelectedText = "";
            this.log_tb.SelectionLength = 0;
            this.log_tb.SelectionStart = 0;
            this.log_tb.Size = new System.Drawing.Size(111, 23);
            this.log_tb.TabIndex = 8;
            this.log_tb.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(180, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Логин";
            // 
            // checkPass
            // 
            this.checkPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkPass.Depth = 0;
            this.checkPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.checkPass.Location = new System.Drawing.Point(296, 202);
            this.checkPass.Margin = new System.Windows.Forms.Padding(0);
            this.checkPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPass.Name = "checkPass";
            this.checkPass.Ripple = true;
            this.checkPass.Size = new System.Drawing.Size(24, 24);
            this.checkPass.TabIndex = 14;
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.CheckPass_CheckedChanged);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 375);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.login_b);
            this.Controls.Add(this.reg_b);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton login_b;
        private MaterialSkin.Controls.MaterialFlatButton reg_b;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass_tb;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField log_tb;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox checkPass;
    }
}

