namespace for_driving
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.pdfwindow = new AxAcroPDFLib.AxAcroPDF();
            this.return_b = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pdfwindow)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfwindow
            // 
            this.pdfwindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfwindow.Enabled = true;
            this.pdfwindow.Location = new System.Drawing.Point(131, 85);
            this.pdfwindow.Name = "pdfwindow";
            this.pdfwindow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfwindow.OcxState")));
            this.pdfwindow.Size = new System.Drawing.Size(647, 486);
            this.pdfwindow.TabIndex = 12;
            // 
            // return_b
            // 
            this.return_b.Depth = 0;
            this.return_b.Location = new System.Drawing.Point(12, 85);
            this.return_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_b.Name = "return_b";
            this.return_b.Primary = true;
            this.return_b.Size = new System.Drawing.Size(107, 40);
            this.return_b.TabIndex = 11;
            this.return_b.Text = "Назад";
            this.return_b.UseVisualStyleBackColor = true;
            this.return_b.Click += new System.EventHandler(this.Return_b_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 594);
            this.Controls.Add(this.pdfwindow);
            this.Controls.Add(this.return_b);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.Text = "Справка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Help_FormClosed);
            this.Load += new System.EventHandler(this.Help_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfwindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfwindow;
        private MaterialSkin.Controls.MaterialRaisedButton return_b;
    }
}