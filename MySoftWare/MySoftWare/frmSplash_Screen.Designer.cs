namespace MySoftWare
{
    partial class frmSplash_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash_Screen));
            this.Splash_Screen_Timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.Splash_Screen_ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.lbl_ProgramInfomation = new System.Windows.Forms.Label();
            this.lbl_Loading = new System.Windows.Forms.Label();
            this.btn_Splash_Screen_Exit = new System.Windows.Forms.PictureBox();
            this.pnl_Move_SplashScreen = new System.Windows.Forms.Panel();
            this.ShortLogo = new System.Windows.Forms.PictureBox();
            this.Splash_Screen_Logo_Picture = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Splash_Screen_Exit)).BeginInit();
            this.pnl_Move_SplashScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShortLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Splash_Screen_Logo_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Splash_Screen_Timer
            // 
            this.Splash_Screen_Timer.Enabled = true;
            this.Splash_Screen_Timer.Tick += new System.EventHandler(this.Splash_Screen_Timer_Tick);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            resources.ApplyResources(this.bunifuPanel1, "bunifuPanel1");
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.Splash_Screen_ProgressBar);
            this.bunifuPanel1.Controls.Add(this.lbl_ProgramInfomation);
            this.bunifuPanel1.Controls.Add(this.lbl_Loading);
            this.bunifuPanel1.Controls.Add(this.btn_Splash_Screen_Exit);
            this.bunifuPanel1.Controls.Add(this.pnl_Move_SplashScreen);
            this.bunifuPanel1.Controls.Add(this.Splash_Screen_Logo_Picture);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            // 
            // Splash_Screen_ProgressBar
            // 
            this.Splash_Screen_ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Splash_Screen_ProgressBar.AnimationSpeed = 450;
            this.Splash_Screen_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Splash_Screen_ProgressBar, "Splash_Screen_ProgressBar");
            this.Splash_Screen_ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.Splash_Screen_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Splash_Screen_ProgressBar.InnerMargin = 2;
            this.Splash_Screen_ProgressBar.InnerWidth = -1;
            this.Splash_Screen_ProgressBar.MarqueeAnimationSpeed = 2000;
            this.Splash_Screen_ProgressBar.Name = "Splash_Screen_ProgressBar";
            this.Splash_Screen_ProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.Splash_Screen_ProgressBar.OuterMargin = -25;
            this.Splash_Screen_ProgressBar.OuterWidth = 26;
            this.Splash_Screen_ProgressBar.ProgressColor = System.Drawing.Color.Lime;
            this.Splash_Screen_ProgressBar.ProgressWidth = 8;
            this.Splash_Screen_ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Splash_Screen_ProgressBar.StartAngle = 270;
            this.Splash_Screen_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Splash_Screen_ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Splash_Screen_ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Splash_Screen_ProgressBar.SubscriptText = "";
            this.Splash_Screen_ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Splash_Screen_ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Splash_Screen_ProgressBar.SuperscriptText = "";
            this.Splash_Screen_ProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Splash_Screen_ProgressBar.Value = 68;
            // 
            // lbl_ProgramInfomation
            // 
            resources.ApplyResources(this.lbl_ProgramInfomation, "lbl_ProgramInfomation");
            this.lbl_ProgramInfomation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProgramInfomation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lbl_ProgramInfomation.Name = "lbl_ProgramInfomation";
            // 
            // lbl_Loading
            // 
            resources.ApplyResources(this.lbl_Loading, "lbl_Loading");
            this.lbl_Loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lbl_Loading.Name = "lbl_Loading";
            // 
            // btn_Splash_Screen_Exit
            // 
            this.btn_Splash_Screen_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Splash_Screen_Exit.Image = global::MySoftWare.Properties.Resources.icons8_multiply_501;
            resources.ApplyResources(this.btn_Splash_Screen_Exit, "btn_Splash_Screen_Exit");
            this.btn_Splash_Screen_Exit.Name = "btn_Splash_Screen_Exit";
            this.btn_Splash_Screen_Exit.TabStop = false;
            this.btn_Splash_Screen_Exit.Click += new System.EventHandler(this.btn_Splash_Screen_Exit_Click);
            // 
            // pnl_Move_SplashScreen
            // 
            this.pnl_Move_SplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Move_SplashScreen.Controls.Add(this.ShortLogo);
            resources.ApplyResources(this.pnl_Move_SplashScreen, "pnl_Move_SplashScreen");
            this.pnl_Move_SplashScreen.Name = "pnl_Move_SplashScreen";
            this.pnl_Move_SplashScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_SplashScreen_MouseDown);
            this.pnl_Move_SplashScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_SplashScreen_MouseMove);
            this.pnl_Move_SplashScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_SplashScreen_MouseUp);
            // 
            // ShortLogo
            // 
            this.ShortLogo.Image = global::MySoftWare.Properties.Resources.icons8_sass_avatar_500__1_1;
            resources.ApplyResources(this.ShortLogo, "ShortLogo");
            this.ShortLogo.Name = "ShortLogo";
            this.ShortLogo.TabStop = false;
            // 
            // Splash_Screen_Logo_Picture
            // 
            this.Splash_Screen_Logo_Picture.BackColor = System.Drawing.Color.Transparent;
            this.Splash_Screen_Logo_Picture.Image = global::MySoftWare.Properties.Resources.icons8_sass_5001;
            resources.ApplyResources(this.Splash_Screen_Logo_Picture, "Splash_Screen_Logo_Picture");
            this.Splash_Screen_Logo_Picture.Name = "Splash_Screen_Logo_Picture";
            this.Splash_Screen_Logo_Picture.TabStop = false;
            // 
            // frmSplash_Screen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash_Screen";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Splash_Screen_Exit)).EndInit();
            this.pnl_Move_SplashScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShortLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Splash_Screen_Logo_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox Splash_Screen_Logo_Picture;
        private System.Windows.Forms.PictureBox btn_Splash_Screen_Exit;
        private System.Windows.Forms.Label lbl_ProgramInfomation;
        private System.Windows.Forms.Label lbl_Loading;
        private System.Windows.Forms.Panel pnl_Move_SplashScreen;
        private System.Windows.Forms.PictureBox ShortLogo;
        private CircularProgressBar.CircularProgressBar Splash_Screen_ProgressBar;
        private System.Windows.Forms.Timer Splash_Screen_Timer;
    }
}