namespace FlappyBird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeDown = new PictureBox();
            flappyBird = new PictureBox();
            pipeUp = new PictureBox();
            ground = new PictureBox();
            scoreLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeDown
            // 
            pipeDown.Image = Properties.Resources.pipeDown6;
            pipeDown.Location = new Point(553, -22);
            pipeDown.Name = "pipeDown";
            pipeDown.Size = new Size(63, 152);
            pipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeDown.TabIndex = 0;
            pipeDown.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(66, 173);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(52, 52);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // pipeUp
            // 
            pipeUp.Image = Properties.Resources.pipeUp;
            pipeUp.Location = new Point(553, 249);
            pipeUp.Name = "pipeUp";
            pipeUp.Size = new Size(63, 145);
            pipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeUp.TabIndex = 2;
            pipeUp.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground1;
            ground.Location = new Point(0, 392);
            ground.Name = "ground";
            ground.Size = new Size(803, 58);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Bisque;
            scoreLabel.Font = new Font("Lucida Sans Unicode", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(12, 407);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(130, 34);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(670, 450);
            Controls.Add(scoreLabel);
            Controls.Add(ground);
            Controls.Add(pipeUp);
            Controls.Add(flappyBird);
            Controls.Add(pipeDown);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)pipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeDown;
        private PictureBox flappyBird;
        private PictureBox pipeUp;
        private PictureBox ground;
        private Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}