namespace for_driving
{
    partial class Theory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theory));
            this.return_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // return_b
            // 
            this.return_b.Depth = 0;
            this.return_b.Location = new System.Drawing.Point(12, 81);
            this.return_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_b.Name = "return_b";
            this.return_b.Primary = true;
            this.return_b.Size = new System.Drawing.Size(107, 40);
            this.return_b.TabIndex = 9;
            this.return_b.Text = "Назад";
            this.return_b.UseVisualStyleBackColor = true;
            this.return_b.Click += new System.EventHandler(this.Return_b_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(134, 81);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(647, 486);
            this.axAcroPDF1.TabIndex = 10;
            // 
            // Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 594);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.return_b);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Theory";
            this.Text = "Теория";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Theory_FormClosed);
            this.Load += new System.EventHandler(this.Theory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private MaterialSkin.Controls.MaterialRaisedButton return_b;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}