namespace for_driving
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.reg_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.return_b = new MaterialSkin.Controls.MaterialFlatButton();
            this.fio_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pass_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.log_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkPass = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // reg_b
            // 
            this.reg_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reg_b.Depth = 0;
            this.reg_b.Location = new System.Drawing.Point(156, 316);
            this.reg_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.reg_b.Name = "reg_b";
            this.reg_b.Primary = true;
            this.reg_b.Size = new System.Drawing.Size(170, 38);
            this.reg_b.TabIndex = 22;
            this.reg_b.Text = "зарегистрироваться";
            this.reg_b.UseVisualStyleBackColor = true;
            this.reg_b.Click += new System.EventHandler(this.Reg_b_Click_1);
            // 
            // return_b
            // 
            this.return_b.AutoSize = true;
            this.return_b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.return_b.Depth = 0;
            this.return_b.Location = new System.Drawing.Point(13, 75);
            this.return_b.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.return_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_b.Name = "return_b";
            this.return_b.Primary = false;
            this.return_b.Size = new System.Drawing.Size(59, 36);
            this.return_b.TabIndex = 21;
            this.return_b.Text = "назад";
            this.return_b.UseVisualStyleBackColor = true;
            this.return_b.Click += new System.EventHandler(this.Return_b_Click_1);
            // 
            // fio_tb
            // 
            this.fio_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fio_tb.Depth = 0;
            this.fio_tb.Hint = "";
            this.fio_tb.Location = new System.Drawing.Point(156, 263);
            this.fio_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.PasswordChar = '\0';
            this.fio_tb.SelectedText = "";
            this.fio_tb.SelectionLength = 0;
            this.fio_tb.SelectionStart = 0;
            this.fio_tb.Size = new System.Drawing.Size(170, 23);
            this.fio_tb.TabIndex = 20;
            this.fio_tb.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(152, 241);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Введите ФИО";
            // 
            // pass_tb
            // 
            this.pass_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_tb.Depth = 0;
            this.pass_tb.Hint = "";
            this.pass_tb.Location = new System.Drawing.Point(156, 204);
            this.pass_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.PasswordChar = '\0';
            this.pass_tb.SelectedText = "";
            this.pass_tb.SelectionLength = 0;
            this.pass_tb.SelectionStart = 0;
            this.pass_tb.Size = new System.Drawing.Size(170, 23);
            this.pass_tb.TabIndex = 18;
            this.pass_tb.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(152, 182);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Введите пароль";
            // 
            // log_tb
            // 
            this.log_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_tb.Depth = 0;
            this.log_tb.Hint = "";
            this.log_tb.Location = new System.Drawing.Point(156, 139);
            this.log_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.log_tb.Name = "log_tb";
            this.log_tb.PasswordChar = '\0';
            this.log_tb.SelectedText = "";
            this.log_tb.SelectionLength = 0;
            this.log_tb.SelectionStart = 0;
            this.log_tb.Size = new System.Drawing.Size(170, 23);
            this.log_tb.TabIndex = 16;
            this.log_tb.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(152, 117);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Введите логин";
            // 
            // checkPass
            // 
            this.checkPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkPass.Depth = 0;
            this.checkPass.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkPass.Location = new System.Drawing.Point(329, 204);
            this.checkPass.Margin = new System.Windows.Forms.Padding(0);
            this.checkPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPass.Name = "checkPass";
            this.checkPass.Ripple = true;
            this.checkPass.Size = new System.Drawing.Size(24, 24);
            this.checkPass.TabIndex = 23;
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.CheckPass_CheckedChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 375);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.reg_b);
            this.Controls.Add(this.return_b);
            this.Controls.Add(this.fio_tb);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton reg_b;
        private MaterialSkin.Controls.MaterialFlatButton return_b;
        private MaterialSkin.Controls.MaterialSingleLineTextField fio_tb;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass_tb;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField log_tb;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox checkPass;
    }
}