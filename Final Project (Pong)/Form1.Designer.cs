namespace Final_Project__Pong_
{
    partial class Form1
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
            this.playarea = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.PictureBox();
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.p1score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p2score = new System.Windows.Forms.Label();
            this.playarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            this.SuspendLayout();
            // 
            // playarea
            // 
            this.playarea.Controls.Add(this.p2score);
            this.playarea.Controls.Add(this.label2);
            this.playarea.Controls.Add(this.p1score);
            this.playarea.Controls.Add(this.label1);
            this.playarea.Controls.Add(this.ball);
            this.playarea.Controls.Add(this.paddle1);
            this.playarea.Controls.Add(this.paddle2);
            this.playarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playarea.Location = new System.Drawing.Point(0, 0);
            this.playarea.Name = "playarea";
            this.playarea.Size = new System.Drawing.Size(800, 450);
            this.playarea.TabIndex = 0;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(394, 192);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.Color.Red;
            this.paddle1.Location = new System.Drawing.Point(343, 12);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(113, 17);
            this.paddle1.TabIndex = 1;
            this.paddle1.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.Color.Blue;
            this.paddle2.Location = new System.Drawing.Point(343, 421);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(113, 17);
            this.paddle2.TabIndex = 0;
            this.paddle2.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1: ";
            // 
            // p1score
            // 
            this.p1score.AutoSize = true;
            this.p1score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1score.Location = new System.Drawing.Point(85, 168);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(20, 24);
            this.p1score.TabIndex = 4;
            this.p1score.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2: ";
            // 
            // p2score
            // 
            this.p2score.AutoSize = true;
            this.p2score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2score.Location = new System.Drawing.Point(85, 202);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(20, 24);
            this.p2score.TabIndex = 6;
            this.p2score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playarea);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playarea.ResumeLayout(false);
            this.playarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playarea;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label p2score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label p1score;
        private System.Windows.Forms.Label label1;
    }
}

