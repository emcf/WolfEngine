namespace WolfEngine
{
    partial class frmMain
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
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.pnlDraw2 = new System.Windows.Forms.Panel();
            this.pnlDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Controls.Add(this.pnlDraw2);
            this.pnlDraw.Location = new System.Drawing.Point(13, 13);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(759, 367);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // pnlDraw2
            // 
            this.pnlDraw2.Location = new System.Drawing.Point(560, 190);
            this.pnlDraw2.Name = "pnlDraw2";
            this.pnlDraw2.Size = new System.Drawing.Size(196, 174);
            this.pnlDraw2.TabIndex = 1;
            this.pnlDraw2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw2_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 392);
            this.Controls.Add(this.pnlDraw);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "WolfEngine";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnlDraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Panel pnlDraw2;
    }
}

