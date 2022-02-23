
namespace SimpleHangmanGame
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
            this.guessBtn = new System.Windows.Forms.Button();
            this.hiddenWordLbl = new System.Windows.Forms.Label();
            this.warngLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testedLetters = new System.Windows.Forms.Label();
            this.quitBtn = new System.Windows.Forms.Button();
            this.lostLbl = new System.Windows.Forms.Label();
            this.winLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guessBtn
            // 
            this.guessBtn.Location = new System.Drawing.Point(345, 522);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(75, 23);
            this.guessBtn.TabIndex = 0;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // hiddenWordLbl
            // 
            this.hiddenWordLbl.AutoSize = true;
            this.hiddenWordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenWordLbl.Location = new System.Drawing.Point(356, 357);
            this.hiddenWordLbl.Name = "hiddenWordLbl";
            this.hiddenWordLbl.Size = new System.Drawing.Size(64, 25);
            this.hiddenWordLbl.TabIndex = 1;
            this.hiddenWordLbl.Text = "label1";
            this.hiddenWordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hiddenWordLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // warngLbl
            // 
            this.warngLbl.AutoSize = true;
            this.warngLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warngLbl.ForeColor = System.Drawing.Color.Red;
            this.warngLbl.Location = new System.Drawing.Point(214, 397);
            this.warngLbl.Name = "warngLbl";
            this.warngLbl.Size = new System.Drawing.Size(350, 40);
            this.warngLbl.TabIndex = 2;
            this.warngLbl.Text = "Hey! That\'s too many characters! You scoundrel!\r\nOne point added!";
            this.warngLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warngLbl.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::SimpleHangmanGame.Properties.Resources.HangmanGamePic0;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 342);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // testedLetters
            // 
            this.testedLetters.AutoSize = true;
            this.testedLetters.Location = new System.Drawing.Point(12, 491);
            this.testedLetters.Name = "testedLetters";
            this.testedLetters.Size = new System.Drawing.Size(78, 13);
            this.testedLetters.TabIndex = 5;
            this.testedLetters.Text = "Tested Letters:";
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(345, 522);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Visible = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // lostLbl
            // 
            this.lostLbl.AutoSize = true;
            this.lostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostLbl.ForeColor = System.Drawing.Color.Red;
            this.lostLbl.Location = new System.Drawing.Point(225, 386);
            this.lostLbl.Name = "lostLbl";
            this.lostLbl.Size = new System.Drawing.Size(327, 20);
            this.lostLbl.TabIndex = 7;
            this.lostLbl.Text = "You lost! Remove yourself from my presence!";
            this.lostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lostLbl.Visible = false;
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.winLbl.Location = new System.Drawing.Point(214, 382);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(332, 40);
            this.winLbl.TabIndex = 8;
            this.winLbl.Text = "Congratulations, you win. Happy for you, truly. \r\nInitializing Bitcoin mining..";
            this.winLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 600);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.lostLbl);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.testedLetters);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.warngLbl);
            this.Controls.Add(this.hiddenWordLbl);
            this.Controls.Add(this.guessBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Label hiddenWordLbl;
        private System.Windows.Forms.Label warngLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label testedLetters;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label lostLbl;
        private System.Windows.Forms.Label winLbl;
    }
}

