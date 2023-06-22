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
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.lblFightVSEnemy = new System.Windows.Forms.Label();
            this.pbarLifepoints = new System.Windows.Forms.ProgressBar();
            this.pbActivePokegotchi = new System.Windows.Forms.PictureBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pnlBottomBar = new System.Windows.Forms.Panel();
            this.btnAttack4 = new System.Windows.Forms.Button();
            this.btnAttack3 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.lblPokegotchi3 = new System.Windows.Forms.Label();
            this.lblPokegotchi2 = new System.Windows.Forms.Label();
            this.lblPokegotchi1 = new System.Windows.Forms.Label();
            this.pbarPokegotchi3 = new System.Windows.Forms.ProgressBar();
            this.pbarPokegotchi2 = new System.Windows.Forms.ProgressBar();
            this.pbarPokegotchi1 = new System.Windows.Forms.ProgressBar();
            this.pbPokegotchi3 = new System.Windows.Forms.PictureBox();
            this.pbPokegotchi2 = new System.Windows.Forms.PictureBox();
            this.pbPokegotchi1 = new System.Windows.Forms.PictureBox();
            this.pnl_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivePokegotchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            this.pnlBottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(802, 40);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(144, 49);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(162)))), ((int)(((byte)(179)))));
            this.pnl_TopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_TopBar.Controls.Add(this.lblFightVSEnemy);
            this.pnl_TopBar.Controls.Add(this.pbarLifepoints);
            this.pnl_TopBar.Controls.Add(this.btn_back);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(952, 95);
            this.pnl_TopBar.TabIndex = 5;
            // 
            // lblFightVSEnemy
            // 
            this.lblFightVSEnemy.AutoSize = true;
            this.lblFightVSEnemy.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFightVSEnemy.ForeColor = System.Drawing.Color.White;
            this.lblFightVSEnemy.Location = new System.Drawing.Point(470, 37);
            this.lblFightVSEnemy.Name = "lblFightVSEnemy";
            this.lblFightVSEnemy.Size = new System.Drawing.Size(230, 38);
            this.lblFightVSEnemy.TabIndex = 6;
            this.lblFightVSEnemy.Text = "Fireboy VS. Venti";
            // 
            // pbarLifepoints
            // 
            this.pbarLifepoints.Location = new System.Drawing.Point(13, 41);
            this.pbarLifepoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbarLifepoints.Name = "pbarLifepoints";
            this.pbarLifepoints.Size = new System.Drawing.Size(399, 36);
            this.pbarLifepoints.TabIndex = 5;
            // 
            // pbActivePokegotchi
            // 
            this.pbActivePokegotchi.Image = global::Pokegotchi_SWP.Properties.Resources.Fireboy_Feuer;
            this.pbActivePokegotchi.Location = new System.Drawing.Point(14, 104);
            this.pbActivePokegotchi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbActivePokegotchi.Name = "pbActivePokegotchi";
            this.pbActivePokegotchi.Size = new System.Drawing.Size(346, 347);
            this.pbActivePokegotchi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActivePokegotchi.TabIndex = 6;
            this.pbActivePokegotchi.TabStop = false;
            // 
            // pbEnemy
            // 
            this.pbEnemy.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pbEnemy.Location = new System.Drawing.Point(688, 123);
            this.pbEnemy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(199, 212);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemy.TabIndex = 7;
            this.pbEnemy.TabStop = false;
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.pnlBottomBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottomBar.Controls.Add(this.btnAttack4);
            this.pnlBottomBar.Controls.Add(this.btnAttack3);
            this.pnlBottomBar.Controls.Add(this.btnAttack2);
            this.pnlBottomBar.Controls.Add(this.btnAttack1);
            this.pnlBottomBar.Controls.Add(this.lblPokegotchi3);
            this.pnlBottomBar.Controls.Add(this.lblPokegotchi2);
            this.pnlBottomBar.Controls.Add(this.lblPokegotchi1);
            this.pnlBottomBar.Controls.Add(this.pbarPokegotchi3);
            this.pnlBottomBar.Controls.Add(this.pbarPokegotchi2);
            this.pnlBottomBar.Controls.Add(this.pbarPokegotchi1);
            this.pnlBottomBar.Controls.Add(this.pbPokegotchi3);
            this.pnlBottomBar.Controls.Add(this.pbPokegotchi2);
            this.pnlBottomBar.Controls.Add(this.pbPokegotchi1);
            this.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBar.Location = new System.Drawing.Point(0, 478);
            this.pnlBottomBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottomBar.Name = "pnlBottomBar";
            this.pnlBottomBar.Size = new System.Drawing.Size(952, 167);
            this.pnlBottomBar.TabIndex = 8;
            // 
            // btnAttack4
            // 
            this.btnAttack4.Location = new System.Drawing.Point(760, 96);
            this.btnAttack4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttack4.Name = "btnAttack4";
            this.btnAttack4.Size = new System.Drawing.Size(126, 47);
            this.btnAttack4.TabIndex = 12;
            this.btnAttack4.Text = "Angriff4";
            this.btnAttack4.UseVisualStyleBackColor = true;
            // 
            // btnAttack3
            // 
            this.btnAttack3.Location = new System.Drawing.Point(622, 96);
            this.btnAttack3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttack3.Name = "btnAttack3";
            this.btnAttack3.Size = new System.Drawing.Size(126, 47);
            this.btnAttack3.TabIndex = 11;
            this.btnAttack3.Text = "Angriff3";
            this.btnAttack3.UseVisualStyleBackColor = true;
            // 
            // btnAttack2
            // 
            this.btnAttack2.Location = new System.Drawing.Point(760, 16);
            this.btnAttack2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(126, 47);
            this.btnAttack2.TabIndex = 10;
            this.btnAttack2.Text = "Angriff2";
            this.btnAttack2.UseVisualStyleBackColor = true;
            // 
            // btnAttack1
            // 
            this.btnAttack1.Location = new System.Drawing.Point(622, 16);
            this.btnAttack1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(126, 47);
            this.btnAttack1.TabIndex = 9;
            this.btnAttack1.Text = "Angriff1";
            this.btnAttack1.UseVisualStyleBackColor = true;
            // 
            // lblPokegotchi3
            // 
            this.lblPokegotchi3.AutoSize = true;
            this.lblPokegotchi3.Location = new System.Drawing.Point(376, 109);
            this.lblPokegotchi3.Name = "lblPokegotchi3";
            this.lblPokegotchi3.Size = new System.Drawing.Size(42, 20);
            this.lblPokegotchi3.TabIndex = 8;
            this.lblPokegotchi3.Text = "Venti";
            this.lblPokegotchi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPokegotchi2
            // 
            this.lblPokegotchi2.AutoSize = true;
            this.lblPokegotchi2.Location = new System.Drawing.Point(195, 109);
            this.lblPokegotchi2.Name = "lblPokegotchi2";
            this.lblPokegotchi2.Size = new System.Drawing.Size(42, 20);
            this.lblPokegotchi2.TabIndex = 7;
            this.lblPokegotchi2.Text = "Venti";
            this.lblPokegotchi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPokegotchi1
            // 
            this.lblPokegotchi1.AutoSize = true;
            this.lblPokegotchi1.Location = new System.Drawing.Point(18, 109);
            this.lblPokegotchi1.Name = "lblPokegotchi1";
            this.lblPokegotchi1.Size = new System.Drawing.Size(42, 20);
            this.lblPokegotchi1.TabIndex = 6;
            this.lblPokegotchi1.Text = "Venti";
            this.lblPokegotchi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbarPokegotchi3
            // 
            this.pbarPokegotchi3.BackColor = System.Drawing.Color.LightGray;
            this.pbarPokegotchi3.Location = new System.Drawing.Point(376, 133);
            this.pbarPokegotchi3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbarPokegotchi3.Name = "pbarPokegotchi3";
            this.pbarPokegotchi3.Size = new System.Drawing.Size(133, 13);
            this.pbarPokegotchi3.TabIndex = 5;
            // 
            // pbarPokegotchi2
            // 
            this.pbarPokegotchi2.BackColor = System.Drawing.Color.LightGray;
            this.pbarPokegotchi2.Location = new System.Drawing.Point(195, 133);
            this.pbarPokegotchi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbarPokegotchi2.Name = "pbarPokegotchi2";
            this.pbarPokegotchi2.Size = new System.Drawing.Size(133, 13);
            this.pbarPokegotchi2.TabIndex = 4;
            // 
            // pbarPokegotchi1
            // 
            this.pbarPokegotchi1.BackColor = System.Drawing.Color.LightGray;
            this.pbarPokegotchi1.Location = new System.Drawing.Point(18, 137);
            this.pbarPokegotchi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbarPokegotchi1.Name = "pbarPokegotchi1";
            this.pbarPokegotchi1.Size = new System.Drawing.Size(133, 13);
            this.pbarPokegotchi1.TabIndex = 3;
            // 
            // pbPokegotchi3
            // 
            this.pbPokegotchi3.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pbPokegotchi3.Location = new System.Drawing.Point(376, 4);
            this.pbPokegotchi3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPokegotchi3.Name = "pbPokegotchi3";
            this.pbPokegotchi3.Size = new System.Drawing.Size(133, 101);
            this.pbPokegotchi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokegotchi3.TabIndex = 2;
            this.pbPokegotchi3.TabStop = false;
            // 
            // pbPokegotchi2
            // 
            this.pbPokegotchi2.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pbPokegotchi2.Location = new System.Drawing.Point(195, 4);
            this.pbPokegotchi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPokegotchi2.Name = "pbPokegotchi2";
            this.pbPokegotchi2.Size = new System.Drawing.Size(133, 101);
            this.pbPokegotchi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokegotchi2.TabIndex = 1;
            this.pbPokegotchi2.TabStop = false;
            // 
            // pbPokegotchi1
            // 
            this.pbPokegotchi1.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pbPokegotchi1.Location = new System.Drawing.Point(18, 4);
            this.pbPokegotchi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPokegotchi1.Name = "pbPokegotchi1";
            this.pbPokegotchi1.Size = new System.Drawing.Size(133, 101);
            this.pbPokegotchi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokegotchi1.TabIndex = 0;
            this.pbPokegotchi1.TabStop = false;
            // 
            // f_Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 645);
            this.Controls.Add(this.pnlBottomBar);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.pbActivePokegotchi);
            this.Controls.Add(this.pnl_TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "f_Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kampf";
            this.pnl_TopBar.ResumeLayout(false);
            this.pnl_TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivePokegotchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlBottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi1)).EndInit();
            this.ResumeLayout(false);

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