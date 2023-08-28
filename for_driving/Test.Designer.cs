namespace for_driving
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.question_lb = new MaterialSkin.Controls.MaterialLabel();
            this.rb_4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.answers_panel = new System.Windows.Forms.Panel();
            this.comment_tb = new System.Windows.Forms.RichTextBox();
            this.secret_lb = new System.Windows.Forms.Label();
            this.forward_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.return_question_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.return_b = new MaterialSkin.Controls.MaterialFlatButton();
            this.picture_panel = new System.Windows.Forms.Panel();
            this.secret_lb_2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_l = new MaterialSkin.Controls.MaterialLabel();
            this.comment_panel = new System.Windows.Forms.Panel();
            this.answers_panel.SuspendLayout();
            this.comment_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // question_lb
            // 
            this.question_lb.AutoEllipsis = true;
            this.question_lb.AutoSize = true;
            this.question_lb.Depth = 0;
            this.question_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.question_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.question_lb.Location = new System.Drawing.Point(12, 72);
            this.question_lb.MaximumSize = new System.Drawing.Size(800, 0);
            this.question_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.question_lb.Name = "question_lb";
            this.question_lb.Size = new System.Drawing.Size(61, 19);
            this.question_lb.TabIndex = 16;
            this.question_lb.Text = "Вопрос";
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Depth = 0;
            this.rb_4.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_4.Location = new System.Drawing.Point(7, 94);
            this.rb_4.Margin = new System.Windows.Forms.Padding(0);
            this.rb_4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_4.Name = "rb_4";
            this.rb_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_4.Ripple = true;
            this.rb_4.Size = new System.Drawing.Size(37, 30);
            this.rb_4.TabIndex = 6;
            this.rb_4.TabStop = true;
            this.rb_4.Text = "4";
            this.rb_4.UseVisualStyleBackColor = true;
            this.rb_4.CheckedChanged += new System.EventHandler(this.Rb_4_CheckedChanged);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Depth = 0;
            this.rb_1.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_1.Location = new System.Drawing.Point(7, 4);
            this.rb_1.Margin = new System.Windows.Forms.Padding(0);
            this.rb_1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_1.Name = "rb_1";
            this.rb_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_1.Ripple = true;
            this.rb_1.Size = new System.Drawing.Size(37, 30);
            this.rb_1.TabIndex = 3;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "1";
            this.rb_1.UseVisualStyleBackColor = true;
            this.rb_1.CheckedChanged += new System.EventHandler(this.Rb_1_CheckedChanged);
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Depth = 0;
            this.rb_2.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_2.Location = new System.Drawing.Point(7, 34);
            this.rb_2.Margin = new System.Windows.Forms.Padding(0);
            this.rb_2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_2.Name = "rb_2";
            this.rb_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_2.Ripple = true;
            this.rb_2.Size = new System.Drawing.Size(37, 30);
            this.rb_2.TabIndex = 4;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "2";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.CheckedChanged += new System.EventHandler(this.Rb_2_CheckedChanged);
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Depth = 0;
            this.rb_3.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_3.Location = new System.Drawing.Point(7, 64);
            this.rb_3.Margin = new System.Windows.Forms.Padding(0);
            this.rb_3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_3.Name = "rb_3";
            this.rb_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_3.Ripple = true;
            this.rb_3.Size = new System.Drawing.Size(37, 30);
            this.rb_3.TabIndex = 5;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "3";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.CheckedChanged += new System.EventHandler(this.Rb_3_CheckedChanged);
            // 
            // answers_panel
            // 
            this.answers_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answers_panel.Controls.Add(this.rb_4);
            this.answers_panel.Controls.Add(this.rb_1);
            this.answers_panel.Controls.Add(this.rb_2);
            this.answers_panel.Controls.Add(this.rb_3);
            this.answers_panel.Location = new System.Drawing.Point(12, 426);
            this.answers_panel.Name = "answers_panel";
            this.answers_panel.Size = new System.Drawing.Size(1103, 127);
            this.answers_panel.TabIndex = 20;
            // 
            // comment_tb
            // 
            this.comment_tb.Enabled = false;
            this.comment_tb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment_tb.Location = new System.Drawing.Point(3, 14);
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(1097, 98);
            this.comment_tb.TabIndex = 7;
            this.comment_tb.Text = "";
            // 
            // secret_lb
            // 
            this.secret_lb.AutoSize = true;
            this.secret_lb.Location = new System.Drawing.Point(799, 673);
            this.secret_lb.Name = "secret_lb";
            this.secret_lb.Size = new System.Drawing.Size(0, 13);
            this.secret_lb.TabIndex = 19;
            // 
            // forward_b
            // 
            this.forward_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forward_b.Depth = 0;
            this.forward_b.Location = new System.Drawing.Point(857, 687);
            this.forward_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.forward_b.Name = "forward_b";
            this.forward_b.Primary = true;
            this.forward_b.Size = new System.Drawing.Size(258, 36);
            this.forward_b.TabIndex = 17;
            this.forward_b.Text = "Далее";
            this.forward_b.UseVisualStyleBackColor = true;
            this.forward_b.Click += new System.EventHandler(this.Forward_b_Click);
            // 
            // return_question_b
            // 
            this.return_question_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.return_question_b.Depth = 0;
            this.return_question_b.Location = new System.Drawing.Point(593, 687);
            this.return_question_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_question_b.Name = "return_question_b";
            this.return_question_b.Primary = true;
            this.return_question_b.Size = new System.Drawing.Size(258, 36);
            this.return_question_b.TabIndex = 18;
            this.return_question_b.Text = "Предыдущий вопрос";
            this.return_question_b.UseVisualStyleBackColor = true;
            this.return_question_b.Click += new System.EventHandler(this.Return_question_b_Click);
            // 
            // return_b
            // 
            this.return_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.return_b.AutoSize = true;
            this.return_b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.return_b.Depth = 0;
            this.return_b.Location = new System.Drawing.Point(14, 687);
            this.return_b.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.return_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_b.Name = "return_b";
            this.return_b.Primary = false;
            this.return_b.Size = new System.Drawing.Size(59, 36);
            this.return_b.TabIndex = 23;
            this.return_b.Text = "Назад";
            this.return_b.UseVisualStyleBackColor = true;
            this.return_b.Click += new System.EventHandler(this.Return_b_Click_1);
            // 
            // picture_panel
            // 
            this.picture_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_panel.AutoSize = true;
            this.picture_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_panel.Location = new System.Drawing.Point(12, 150);
            this.picture_panel.Name = "picture_panel";
            this.picture_panel.Size = new System.Drawing.Size(1103, 270);
            this.picture_panel.TabIndex = 21;
            // 
            // secret_lb_2
            // 
            this.secret_lb_2.AutoSize = true;
            this.secret_lb_2.Location = new System.Drawing.Point(471, 710);
            this.secret_lb_2.Name = "secret_lb_2";
            this.secret_lb_2.Size = new System.Drawing.Size(0, 13);
            this.secret_lb_2.TabIndex = 24;
            this.secret_lb_2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // time_l
            // 
            this.time_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time_l.AutoSize = true;
            this.time_l.Depth = 0;
            this.time_l.Font = new System.Drawing.Font("Roboto", 11F);
            this.time_l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.time_l.Location = new System.Drawing.Point(1062, 72);
            this.time_l.MouseState = MaterialSkin.MouseState.HOVER;
            this.time_l.Name = "time_l";
            this.time_l.Size = new System.Drawing.Size(53, 19);
            this.time_l.TabIndex = 25;
            this.time_l.Text = "Время";
            // 
            // comment_panel
            // 
            this.comment_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comment_panel.Controls.Add(this.comment_tb);
            this.comment_panel.Location = new System.Drawing.Point(12, 559);
            this.comment_panel.Name = "comment_panel";
            this.comment_panel.Size = new System.Drawing.Size(1103, 119);
            this.comment_panel.TabIndex = 26;
            this.comment_panel.Visible = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 735);
            this.Controls.Add(this.answers_panel);
            this.Controls.Add(this.time_l);
            this.Controls.Add(this.secret_lb_2);
            this.Controls.Add(this.question_lb);
            this.Controls.Add(this.secret_lb);
            this.Controls.Add(this.forward_b);
            this.Controls.Add(this.return_question_b);
            this.Controls.Add(this.return_b);
            this.Controls.Add(this.picture_panel);
            this.Controls.Add(this.comment_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1127, 726);
            this.Name = "Test";
            this.Text = "Тест";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test_FormClosed);
            this.Load += new System.EventHandler(this.Test_Load);
            this.answers_panel.ResumeLayout(false);
            this.answers_panel.PerformLayout();
            this.comment_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialLabel question_lb;
        public MaterialSkin.Controls.MaterialRadioButton rb_4;
        public MaterialSkin.Controls.MaterialRadioButton rb_1;
        public MaterialSkin.Controls.MaterialRadioButton rb_2;
        public MaterialSkin.Controls.MaterialRadioButton rb_3;
        public System.Windows.Forms.Label secret_lb;
        public MaterialSkin.Controls.MaterialRaisedButton forward_b;
        public MaterialSkin.Controls.MaterialRaisedButton return_question_b;
        public System.Windows.Forms.Label secret_lb_2;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialLabel time_l;
        public MaterialSkin.Controls.MaterialFlatButton return_b;
        public System.Windows.Forms.Panel picture_panel;
        public System.Windows.Forms.Panel answers_panel;
        public System.Windows.Forms.RichTextBox comment_tb;
        public System.Windows.Forms.Panel comment_panel;
    }
}