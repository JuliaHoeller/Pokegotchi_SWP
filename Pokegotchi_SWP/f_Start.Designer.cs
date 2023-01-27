namespace Pokegotchi_SWP
{
    partial class f_Start
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
            this.pbl_Start = new System.Windows.Forms.Panel();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pbl_Start.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbl_Start
            // 
            this.pbl_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(162)))), ((int)(((byte)(179)))));
            this.pbl_Start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbl_Start.Controls.Add(this.lbl_Start);
            this.pbl_Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbl_Start.Location = new System.Drawing.Point(0, 0);
            this.pbl_Start.Name = "pbl_Start";
            this.pbl_Start.Size = new System.Drawing.Size(384, 154);
            this.pbl_Start.TabIndex = 0;
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Font = new System.Drawing.Font("Franklin Gothic Book", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Start.ForeColor = System.Drawing.Color.White;
            this.lbl_Start.Location = new System.Drawing.Point(80, 63);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(230, 52);
            this.lbl_Start.TabIndex = 0;
            this.lbl_Start.Text = "Pokegotchi";
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(162)))), ((int)(((byte)(179)))));
            this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadGame.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadGame.ForeColor = System.Drawing.Color.White;
            this.btnLoadGame.Location = new System.Drawing.Point(81, 313);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(230, 86);
            this.btnLoadGame.TabIndex = 2;
            this.btnLoadGame.Text = "Spiel laden";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(162)))), ((int)(((byte)(179)))));
            this.btnCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCredits.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCredits.ForeColor = System.Drawing.Color.White;
            this.btnCredits.Location = new System.Drawing.Point(81, 421);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(230, 86);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = false;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(162)))), ((int)(((byte)(179)))));
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(81, 205);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(230, 86);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Neues Spiel";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // f_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 563);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.pbl_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "f_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.pbl_Start.ResumeLayout(false);
            this.pbl_Start.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pbl_Start;
        private Label lbl_Start;
        private Button btnLoadGame;
        private Button btnCredits;
        private Button btnNewGame;
    }
}