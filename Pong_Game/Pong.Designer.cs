namespace Pong_Game
{
    partial class Pong
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
            this.horzT = new System.Windows.Forms.Timer(this.components);
            this.vert = new System.Windows.Forms.Timer(this.components);
            this.inputT = new System.Windows.Forms.Timer(this.components);
            this.collisionT = new System.Windows.Forms.Timer(this.components);
            this.paddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // horzT
            // 
            this.horzT.Enabled = true;
            this.horzT.Interval = 10;
            this.horzT.Tick += new System.EventHandler(this.horzT_Tick);
            // 
            // vert
            // 
            this.vert.Enabled = true;
            this.vert.Interval = 10;
            this.vert.Tick += new System.EventHandler(this.vert_Tick);
            // 
            // inputT
            // 
            this.inputT.Enabled = true;
            this.inputT.Interval = 10;
            this.inputT.Tick += new System.EventHandler(this.inputT_Tick);
            // 
            // collisionT
            // 
            this.collisionT.Enabled = true;
            this.collisionT.Interval = 10;
            this.collisionT.Tick += new System.EventHandler(this.collisionT_Tick);
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.paddle.Location = new System.Drawing.Point(302, 392);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(175, 21);
            this.paddle.TabIndex = 0;
            this.paddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(400, 173);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(23, 21);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer horzT;
        private System.Windows.Forms.Timer vert;
        private System.Windows.Forms.Timer inputT;
        private System.Windows.Forms.Timer collisionT;
        private PictureBox paddle;
        private PictureBox ball;
    }
}