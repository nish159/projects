namespace Zombie.Shooter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ammoTxt = new System.Windows.Forms.Label();
            this.killTxt = new System.Windows.Forms.Label();
            this.healthTxt = new System.Windows.Forms.Label();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoTxt
            // 
            this.ammoTxt.AutoSize = true;
            this.ammoTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ammoTxt.ForeColor = System.Drawing.Color.White;
            this.ammoTxt.Location = new System.Drawing.Point(30, 16);
            this.ammoTxt.Name = "ammoTxt";
            this.ammoTxt.Size = new System.Drawing.Size(112, 30);
            this.ammoTxt.TabIndex = 0;
            this.ammoTxt.Text = "AMMO: 0";
            // 
            // killTxt
            // 
            this.killTxt.AutoSize = true;
            this.killTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.killTxt.ForeColor = System.Drawing.Color.White;
            this.killTxt.Location = new System.Drawing.Point(379, 16);
            this.killTxt.Name = "killTxt";
            this.killTxt.Size = new System.Drawing.Size(93, 30);
            this.killTxt.TabIndex = 0;
            this.killTxt.Text = "KILLS: 0";
            // 
            // healthTxt
            // 
            this.healthTxt.AutoSize = true;
            this.healthTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.healthTxt.ForeColor = System.Drawing.Color.White;
            this.healthTxt.Location = new System.Drawing.Point(647, 16);
            this.healthTxt.Name = "healthTxt";
            this.healthTxt.Size = new System.Drawing.Size(103, 30);
            this.healthTxt.TabIndex = 0;
            this.healthTxt.Text = "HEALTH:";
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(756, 12);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(150, 34);
            this.healthbar.TabIndex = 1;
            this.healthbar.Value = 100;
            // 
            // player
            // 
            this.player.Image = global::Zombie.Shooter.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(410, 532);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(918, 644);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.healthTxt);
            this.Controls.Add(this.killTxt);
            this.Controls.Add(this.ammoTxt);
            this.Name = "Form1";
            this.Text = "Zombie Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ammoTxt;
        private Label killTxt;
        private Label healthTxt;
        private ProgressBar healthbar;
        private PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
    }
}