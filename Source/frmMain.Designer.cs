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
            this.pnlDraw = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlGun = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlFloor = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlFloorText = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlScore = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlScoreText = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlLives = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlLivesText = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlHP = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlHealthText = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlAmmo = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlAmmoText = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlGunDisplay = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlGuy = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlHPText = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlFloorValue = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlScoreValue = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlLivesValue = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlHPValue = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlAmmoValue = new WolfEngine.frmMain.DoubleBufferedPanel();
            this.pnlDraw.SuspendLayout();
            this.pnlFloor.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.pnlLives.SuspendLayout();
            this.pnlHP.SuspendLayout();
            this.pnlAmmo.SuspendLayout();
            this.pnlGuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlDraw.Controls.Add(this.pnlGun);
            this.pnlDraw.Location = new System.Drawing.Point(12, 12);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(760, 460);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // pnlGun
            // 
            this.pnlGun.BackColor = System.Drawing.Color.Transparent;
            this.pnlGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlGun.Location = new System.Drawing.Point(319, 288);
            this.pnlGun.Name = "pnlGun";
            this.pnlGun.Size = new System.Drawing.Size(154, 189);
            this.pnlGun.TabIndex = 1;
            // 
            // pnlFloor
            // 
            this.pnlFloor.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFloor.Controls.Add(this.pnlFloorValue);
            this.pnlFloor.Controls.Add(this.pnlFloorText);
            this.pnlFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFloor.Location = new System.Drawing.Point(12, 478);
            this.pnlFloor.Name = "pnlFloor";
            this.pnlFloor.Size = new System.Drawing.Size(105, 66);
            this.pnlFloor.TabIndex = 2;
            // 
            // pnlFloorText
            // 
            this.pnlFloorText.BackColor = System.Drawing.Color.Transparent;
            this.pnlFloorText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFloorText.Location = new System.Drawing.Point(3, 5);
            this.pnlFloorText.Name = "pnlFloorText";
            this.pnlFloorText.Size = new System.Drawing.Size(83, 22);
            this.pnlFloorText.TabIndex = 3;
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScore.Controls.Add(this.pnlScoreValue);
            this.pnlScore.Controls.Add(this.pnlScoreText);
            this.pnlScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlScore.Location = new System.Drawing.Point(114, 478);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(121, 66);
            this.pnlScore.TabIndex = 3;
            // 
            // pnlScoreText
            // 
            this.pnlScoreText.BackColor = System.Drawing.Color.Transparent;
            this.pnlScoreText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlScoreText.Location = new System.Drawing.Point(3, 5);
            this.pnlScoreText.Name = "pnlScoreText";
            this.pnlScoreText.Size = new System.Drawing.Size(83, 22);
            this.pnlScoreText.TabIndex = 4;
            // 
            // pnlLives
            // 
            this.pnlLives.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlLives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLives.Controls.Add(this.pnlLivesValue);
            this.pnlLives.Controls.Add(this.pnlLivesText);
            this.pnlLives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLives.Location = new System.Drawing.Point(231, 478);
            this.pnlLives.Name = "pnlLives";
            this.pnlLives.Size = new System.Drawing.Size(112, 66);
            this.pnlLives.TabIndex = 4;
            // 
            // pnlLivesText
            // 
            this.pnlLivesText.BackColor = System.Drawing.Color.Transparent;
            this.pnlLivesText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLivesText.Location = new System.Drawing.Point(3, 5);
            this.pnlLivesText.Name = "pnlLivesText";
            this.pnlLivesText.Size = new System.Drawing.Size(83, 22);
            this.pnlLivesText.TabIndex = 4;
            // 
            // pnlHP
            // 
            this.pnlHP.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHP.Controls.Add(this.pnlHPValue);
            this.pnlHP.Controls.Add(this.pnlHPText);
            this.pnlHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHP.Location = new System.Drawing.Point(440, 478);
            this.pnlHP.Name = "pnlHP";
            this.pnlHP.Size = new System.Drawing.Size(100, 66);
            this.pnlHP.TabIndex = 5;
            // 
            // pnlHealthText
            // 
            this.pnlHealthText.BackColor = System.Drawing.Color.Transparent;
            this.pnlHealthText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlHealthText.Location = new System.Drawing.Point(108, 5);
            this.pnlHealthText.Name = "pnlHealthText";
            this.pnlHealthText.Size = new System.Drawing.Size(87, 22);
            this.pnlHealthText.TabIndex = 4;
            // 
            // pnlAmmo
            // 
            this.pnlAmmo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAmmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmmo.Controls.Add(this.pnlAmmoValue);
            this.pnlAmmo.Controls.Add(this.pnlAmmoText);
            this.pnlAmmo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlAmmo.Location = new System.Drawing.Point(537, 478);
            this.pnlAmmo.Name = "pnlAmmo";
            this.pnlAmmo.Size = new System.Drawing.Size(121, 66);
            this.pnlAmmo.TabIndex = 6;
            // 
            // pnlAmmoText
            // 
            this.pnlAmmoText.BackColor = System.Drawing.Color.Transparent;
            this.pnlAmmoText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAmmoText.Location = new System.Drawing.Point(3, 3);
            this.pnlAmmoText.Name = "pnlAmmoText";
            this.pnlAmmoText.Size = new System.Drawing.Size(83, 22);
            this.pnlAmmoText.TabIndex = 4;
            // 
            // pnlGunDisplay
            // 
            this.pnlGunDisplay.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlGunDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlGunDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGunDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlGunDisplay.Location = new System.Drawing.Point(655, 478);
            this.pnlGunDisplay.Name = "pnlGunDisplay";
            this.pnlGunDisplay.Size = new System.Drawing.Size(117, 66);
            this.pnlGunDisplay.TabIndex = 7;
            // 
            // pnlGuy
            // 
            this.pnlGuy.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlGuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlGuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuy.Controls.Add(this.pnlHealthText);
            this.pnlGuy.Location = new System.Drawing.Point(339, 478);
            this.pnlGuy.Name = "pnlGuy";
            this.pnlGuy.Size = new System.Drawing.Size(102, 66);
            this.pnlGuy.TabIndex = 6;
            // 
            // pnlHPText
            // 
            this.pnlHPText.BackColor = System.Drawing.Color.Transparent;
            this.pnlHPText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHPText.Location = new System.Drawing.Point(7, 3);
            this.pnlHPText.Name = "pnlHPText";
            this.pnlHPText.Size = new System.Drawing.Size(83, 22);
            this.pnlHPText.TabIndex = 5;
            // 
            // pnlFloorValue
            // 
            this.pnlFloorValue.BackColor = System.Drawing.Color.Transparent;
            this.pnlFloorValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFloorValue.Location = new System.Drawing.Point(3, 33);
            this.pnlFloorValue.Name = "pnlFloorValue";
            this.pnlFloorValue.Size = new System.Drawing.Size(83, 22);
            this.pnlFloorValue.TabIndex = 4;
            // 
            // pnlScoreValue
            // 
            this.pnlScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.pnlScoreValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlScoreValue.Location = new System.Drawing.Point(3, 33);
            this.pnlScoreValue.Name = "pnlScoreValue";
            this.pnlScoreValue.Size = new System.Drawing.Size(83, 22);
            this.pnlScoreValue.TabIndex = 4;
            // 
            // pnlLivesValue
            // 
            this.pnlLivesValue.BackColor = System.Drawing.Color.Transparent;
            this.pnlLivesValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLivesValue.Location = new System.Drawing.Point(3, 33);
            this.pnlLivesValue.Name = "pnlLivesValue";
            this.pnlLivesValue.Size = new System.Drawing.Size(83, 22);
            this.pnlLivesValue.TabIndex = 4;
            // 
            // pnlHPValue
            // 
            this.pnlHPValue.BackColor = System.Drawing.Color.Transparent;
            this.pnlHPValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHPValue.Location = new System.Drawing.Point(6, 33);
            this.pnlHPValue.Name = "pnlHPValue";
            this.pnlHPValue.Size = new System.Drawing.Size(83, 22);
            this.pnlHPValue.TabIndex = 5;
            // 
            // pnlAmmoValue
            // 
            this.pnlAmmoValue.BackColor = System.Drawing.Color.Transparent;
            this.pnlAmmoValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAmmoValue.Location = new System.Drawing.Point(3, 33);
            this.pnlAmmoValue.Name = "pnlAmmoValue";
            this.pnlAmmoValue.Size = new System.Drawing.Size(83, 22);
            this.pnlAmmoValue.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 551);
            this.Controls.Add(this.pnlGuy);
            this.Controls.Add(this.pnlGunDisplay);
            this.Controls.Add(this.pnlAmmo);
            this.Controls.Add(this.pnlHP);
            this.Controls.Add(this.pnlLives);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlFloor);
            this.Controls.Add(this.pnlDraw);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "WolfEngine";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnlDraw.ResumeLayout(false);
            this.pnlFloor.ResumeLayout(false);
            this.pnlScore.ResumeLayout(false);
            this.pnlLives.ResumeLayout(false);
            this.pnlHP.ResumeLayout(false);
            this.pnlAmmo.ResumeLayout(false);
            this.pnlGuy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedPanel pnlDraw;
        private frmMain.DoubleBufferedPanel pnlGun;
        private frmMain.DoubleBufferedPanel pnlFloor;
        private frmMain.DoubleBufferedPanel pnlScore;
        private frmMain.DoubleBufferedPanel pnlLives;
        private frmMain.DoubleBufferedPanel pnlHP;
        private frmMain.DoubleBufferedPanel pnlAmmo;
        private frmMain.DoubleBufferedPanel pnlGunDisplay;
        private frmMain.DoubleBufferedPanel pnlGuy;
        private frmMain.DoubleBufferedPanel pnlFloorText;
        private frmMain.DoubleBufferedPanel pnlScoreText;
        private frmMain.DoubleBufferedPanel pnlLivesText;
        private frmMain.DoubleBufferedPanel pnlHealthText;
        private frmMain.DoubleBufferedPanel pnlAmmoText;
        private frmMain.DoubleBufferedPanel pnlHPText;
        private frmMain.DoubleBufferedPanel pnlFloorValue;
        private frmMain.DoubleBufferedPanel pnlScoreValue;
        private frmMain.DoubleBufferedPanel pnlLivesValue;
        private frmMain.DoubleBufferedPanel pnlHPValue;
        private frmMain.DoubleBufferedPanel pnlAmmoValue;

        public class DoubleBufferedPanel : System.Windows.Forms.Panel
        {
            // Double Buffered Panel to remove flickering during panel refreshes
            // This is actually not my code. In fact, I learned what Double Buffering is today.
            public DoubleBufferedPanel()
            {
                this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.UserPaint, true);
            }
        }
    }
}

