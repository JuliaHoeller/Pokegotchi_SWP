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
            pbl_Start = new Panel();
            lbl_Start = new Label();
            btnLoadGame = new Button();
            btnCredits = new Button();
            btnNewGame = new Button();
            pbl_Start.SuspendLayout();
            SuspendLayout();
            // 
            // pbl_Start
            // 
            pbl_Start.BackColor = Color.FromArgb(43, 162, 179);
            pbl_Start.BorderStyle = BorderStyle.FixedSingle;
            pbl_Start.Controls.Add(lbl_Start);
            pbl_Start.Dock = DockStyle.Top;
            pbl_Start.Location = new Point(0, 0);
            pbl_Start.Name = "pbl_Start";
            pbl_Start.Size = new Size(384, 154);
            pbl_Start.TabIndex = 0;
            // 
            // lbl_Start
            // 
            lbl_Start.AutoSize = true;
            lbl_Start.Font = new Font("Franklin Gothic Book", 33.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Start.ForeColor = Color.White;
            lbl_Start.Location = new Point(80, 63);
            lbl_Start.Name = "lbl_Start";
            lbl_Start.Size = new Size(230, 52);
            lbl_Start.TabIndex = 0;
            lbl_Start.Text = "Pokegotchi";
            // 
            // btnLoadGame
            // 
            btnLoadGame.BackColor = Color.FromArgb(43, 162, 179);
            btnLoadGame.Cursor = Cursors.Hand;
            btnLoadGame.FlatStyle = FlatStyle.Popup;
            btnLoadGame.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadGame.ForeColor = Color.White;
            btnLoadGame.Location = new Point(81, 313);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Size = new Size(230, 86);
            btnLoadGame.TabIndex = 2;
            btnLoadGame.Text = "Spiel laden";
            btnLoadGame.UseVisualStyleBackColor = false;
            btnLoadGame.Click += btnLoadGame_Click;
            // 
            // btnCredits
            // 
            btnCredits.BackColor = Color.FromArgb(43, 162, 179);
            btnCredits.Cursor = Cursors.Hand;
            btnCredits.FlatStyle = FlatStyle.Popup;
            btnCredits.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCredits.ForeColor = Color.White;
            btnCredits.Location = new Point(81, 421);
            btnCredits.Name = "btnCredits";
            btnCredits.Size = new Size(230, 86);
            btnCredits.TabIndex = 3;
            btnCredits.Text = "Credits";
            btnCredits.UseVisualStyleBackColor = false;
            btnCredits.Click += btnCredits_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.FromArgb(43, 162, 179);
            btnNewGame.Cursor = Cursors.Hand;
            btnNewGame.FlatStyle = FlatStyle.Popup;
            btnNewGame.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewGame.ForeColor = Color.White;
            btnNewGame.Location = new Point(81, 205);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(230, 86);
            btnNewGame.TabIndex = 4;
            btnNewGame.Text = "Neues Spiel";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // f_Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 563);
            Controls.Add(btnNewGame);
            Controls.Add(btnCredits);
            Controls.Add(btnLoadGame);
            Controls.Add(pbl_Start);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "f_Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            Load += f_Start_Load;
            pbl_Start.ResumeLayout(false);
            pbl_Start.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pbl_Start;
        private Label lbl_Start;
        private Button btnLoadGame;
        private Button btnCredits;
        private Button btnNewGame;
    }
}