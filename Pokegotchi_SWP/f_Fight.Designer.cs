namespace Pokegotchi_SWP
{
    partial class f_Fight
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
            btn_back = new Button();
            pnl_TopBar = new Panel();
            pbActivePokegotchi = new PictureBox();
            pbarLifepoints = new ProgressBar();
            pbEnemy = new PictureBox();
            pnlBottomBar = new Panel();
            pbPokegotchi1 = new PictureBox();
            pbPokegotchi2 = new PictureBox();
            pbPokegotchi3 = new PictureBox();
            pbarPokegotchi1 = new ProgressBar();
            pbarPokegotchi2 = new ProgressBar();
            pbarPokegotchi3 = new ProgressBar();
            lblPokegotchi1 = new Label();
            lblPokegotchi2 = new Label();
            lblPokegotchi3 = new Label();
            lblFightVSEnemy = new Label();
            btnAttack1 = new Button();
            btnAttack2 = new Button();
            btnAttack3 = new Button();
            btnAttack4 = new Button();
            pnl_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbActivePokegotchi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy).BeginInit();
            pnlBottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi3).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.Location = new Point(702, 30);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(126, 37);
            btn_back.TabIndex = 4;
            btn_back.Text = "zurück";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // pnl_TopBar
            // 
            pnl_TopBar.BackColor = Color.FromArgb(43, 162, 179);
            pnl_TopBar.BorderStyle = BorderStyle.FixedSingle;
            pnl_TopBar.Controls.Add(lblFightVSEnemy);
            pnl_TopBar.Controls.Add(pbarLifepoints);
            pnl_TopBar.Controls.Add(btn_back);
            pnl_TopBar.Dock = DockStyle.Top;
            pnl_TopBar.Location = new Point(0, 0);
            pnl_TopBar.Name = "pnl_TopBar";
            pnl_TopBar.Size = new Size(833, 72);
            pnl_TopBar.TabIndex = 5;
            // 
            // pbActivePokegotchi
            // 
            pbActivePokegotchi.Image = Properties.Resources.Fireboy_Feuer;
            pbActivePokegotchi.Location = new Point(12, 78);
            pbActivePokegotchi.Name = "pbActivePokegotchi";
            pbActivePokegotchi.Size = new Size(303, 260);
            pbActivePokegotchi.SizeMode = PictureBoxSizeMode.Zoom;
            pbActivePokegotchi.TabIndex = 6;
            pbActivePokegotchi.TabStop = false;
            // 
            // pbarLifepoints
            // 
            pbarLifepoints.Location = new Point(11, 31);
            pbarLifepoints.Name = "pbarLifepoints";
            pbarLifepoints.Size = new Size(349, 27);
            pbarLifepoints.TabIndex = 5;
            // 
            // pbEnemy
            // 
            pbEnemy.Image = Properties.Resources.venti;
            pbEnemy.Location = new Point(602, 92);
            pbEnemy.Name = "pbEnemy";
            pbEnemy.Size = new Size(174, 159);
            pbEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnemy.TabIndex = 7;
            pbEnemy.TabStop = false;
            // 
            // pnlBottomBar
            // 
            pnlBottomBar.BackColor = Color.FromArgb(231, 231, 231);
            pnlBottomBar.BorderStyle = BorderStyle.FixedSingle;
            pnlBottomBar.Controls.Add(btnAttack4);
            pnlBottomBar.Controls.Add(btnAttack3);
            pnlBottomBar.Controls.Add(btnAttack2);
            pnlBottomBar.Controls.Add(btnAttack1);
            pnlBottomBar.Controls.Add(lblPokegotchi3);
            pnlBottomBar.Controls.Add(lblPokegotchi2);
            pnlBottomBar.Controls.Add(lblPokegotchi1);
            pnlBottomBar.Controls.Add(pbarPokegotchi3);
            pnlBottomBar.Controls.Add(pbarPokegotchi2);
            pnlBottomBar.Controls.Add(pbarPokegotchi1);
            pnlBottomBar.Controls.Add(pbPokegotchi3);
            pnlBottomBar.Controls.Add(pbPokegotchi2);
            pnlBottomBar.Controls.Add(pbPokegotchi1);
            pnlBottomBar.Dock = DockStyle.Bottom;
            pnlBottomBar.Location = new Point(0, 358);
            pnlBottomBar.Name = "pnlBottomBar";
            pnlBottomBar.Size = new Size(833, 126);
            pnlBottomBar.TabIndex = 8;
            // 
            // pbPokegotchi1
            // 
            pbPokegotchi1.Image = Properties.Resources.venti;
            pbPokegotchi1.Location = new Point(16, 3);
            pbPokegotchi1.Name = "pbPokegotchi1";
            pbPokegotchi1.Size = new Size(116, 76);
            pbPokegotchi1.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokegotchi1.TabIndex = 0;
            pbPokegotchi1.TabStop = false;
            // 
            // pbPokegotchi2
            // 
            pbPokegotchi2.Image = Properties.Resources.venti;
            pbPokegotchi2.Location = new Point(171, 3);
            pbPokegotchi2.Name = "pbPokegotchi2";
            pbPokegotchi2.Size = new Size(116, 76);
            pbPokegotchi2.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokegotchi2.TabIndex = 1;
            pbPokegotchi2.TabStop = false;
            // 
            // pbPokegotchi3
            // 
            pbPokegotchi3.Image = Properties.Resources.venti;
            pbPokegotchi3.Location = new Point(329, 3);
            pbPokegotchi3.Name = "pbPokegotchi3";
            pbPokegotchi3.Size = new Size(116, 76);
            pbPokegotchi3.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokegotchi3.TabIndex = 2;
            pbPokegotchi3.TabStop = false;
            // 
            // pbarPokegotchi1
            // 
            pbarPokegotchi1.BackColor = Color.LightGray;
            pbarPokegotchi1.Location = new Point(16, 103);
            pbarPokegotchi1.Name = "pbarPokegotchi1";
            pbarPokegotchi1.Size = new Size(116, 10);
            pbarPokegotchi1.TabIndex = 3;
            // 
            // pbarPokegotchi2
            // 
            pbarPokegotchi2.BackColor = Color.LightGray;
            pbarPokegotchi2.Location = new Point(171, 100);
            pbarPokegotchi2.Name = "pbarPokegotchi2";
            pbarPokegotchi2.Size = new Size(116, 10);
            pbarPokegotchi2.TabIndex = 4;
            // 
            // pbarPokegotchi3
            // 
            pbarPokegotchi3.BackColor = Color.LightGray;
            pbarPokegotchi3.Location = new Point(329, 100);
            pbarPokegotchi3.Name = "pbarPokegotchi3";
            pbarPokegotchi3.Size = new Size(116, 10);
            pbarPokegotchi3.TabIndex = 5;
            // 
            // lblPokegotchi1
            // 
            lblPokegotchi1.AutoSize = true;
            lblPokegotchi1.Location = new Point(16, 82);
            lblPokegotchi1.Name = "lblPokegotchi1";
            lblPokegotchi1.Size = new Size(33, 15);
            lblPokegotchi1.TabIndex = 6;
            lblPokegotchi1.Text = "Venti";
            lblPokegotchi1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPokegotchi2
            // 
            lblPokegotchi2.AutoSize = true;
            lblPokegotchi2.Location = new Point(171, 82);
            lblPokegotchi2.Name = "lblPokegotchi2";
            lblPokegotchi2.Size = new Size(33, 15);
            lblPokegotchi2.TabIndex = 7;
            lblPokegotchi2.Text = "Venti";
            lblPokegotchi2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPokegotchi3
            // 
            lblPokegotchi3.AutoSize = true;
            lblPokegotchi3.Location = new Point(329, 82);
            lblPokegotchi3.Name = "lblPokegotchi3";
            lblPokegotchi3.Size = new Size(33, 15);
            lblPokegotchi3.TabIndex = 8;
            lblPokegotchi3.Text = "Venti";
            lblPokegotchi3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFightVSEnemy
            // 
            lblFightVSEnemy.AutoSize = true;
            lblFightVSEnemy.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblFightVSEnemy.ForeColor = Color.White;
            lblFightVSEnemy.Location = new Point(411, 28);
            lblFightVSEnemy.Name = "lblFightVSEnemy";
            lblFightVSEnemy.Size = new Size(184, 30);
            lblFightVSEnemy.TabIndex = 6;
            lblFightVSEnemy.Text = "Fireboy VS. Venti";
            // 
            // btnAttack1
            // 
            btnAttack1.Location = new Point(544, 12);
            btnAttack1.Name = "btnAttack1";
            btnAttack1.Size = new Size(110, 35);
            btnAttack1.TabIndex = 9;
            btnAttack1.Text = "Angriff1";
            btnAttack1.UseVisualStyleBackColor = true;
            // 
            // btnAttack2
            // 
            btnAttack2.Location = new Point(665, 12);
            btnAttack2.Name = "btnAttack2";
            btnAttack2.Size = new Size(110, 35);
            btnAttack2.TabIndex = 10;
            btnAttack2.Text = "Angriff2";
            btnAttack2.UseVisualStyleBackColor = true;
            // 
            // btnAttack3
            // 
            btnAttack3.Location = new Point(544, 72);
            btnAttack3.Name = "btnAttack3";
            btnAttack3.Size = new Size(110, 35);
            btnAttack3.TabIndex = 11;
            btnAttack3.Text = "Angriff3";
            btnAttack3.UseVisualStyleBackColor = true;
            // 
            // btnAttack4
            // 
            btnAttack4.Location = new Point(665, 72);
            btnAttack4.Name = "btnAttack4";
            btnAttack4.Size = new Size(110, 35);
            btnAttack4.TabIndex = 12;
            btnAttack4.Text = "Angriff4";
            btnAttack4.UseVisualStyleBackColor = true;
            // 
            // f_Fight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 484);
            Controls.Add(pnlBottomBar);
            Controls.Add(pbEnemy);
            Controls.Add(pbActivePokegotchi);
            Controls.Add(pnl_TopBar);
            Name = "f_Fight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f_Fight";
            pnl_TopBar.ResumeLayout(false);
            pnl_TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbActivePokegotchi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy).EndInit();
            pnlBottomBar.ResumeLayout(false);
            pnlBottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private Panel pnl_TopBar;
        private ProgressBar pbarLifepoints;
        private PictureBox pbActivePokegotchi;
        private PictureBox pbEnemy;
        private Panel pnlBottomBar;
        private ProgressBar pbarPokegotchi1;
        private PictureBox pbPokegotchi3;
        private PictureBox pbPokegotchi2;
        private PictureBox pbPokegotchi1;
        private Label lblFightVSEnemy;
        private Label lblPokegotchi3;
        private Label lblPokegotchi2;
        private Label lblPokegotchi1;
        private ProgressBar pbarPokegotchi3;
        private ProgressBar pbarPokegotchi2;
        private Button btnAttack4;
        private Button btnAttack3;
        private Button btnAttack2;
        private Button btnAttack1;
    }
}