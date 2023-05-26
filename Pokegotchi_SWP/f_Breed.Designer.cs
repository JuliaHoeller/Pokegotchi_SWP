namespace Pokegotchi_SWP
{
    partial class f_Breed
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
            btn_Back = new Button();
            pb_Pokegotchi1 = new PictureBox();
            pb_Heart = new PictureBox();
            pb_Pokegotchi2 = new PictureBox();
            pnl_Breed = new Panel();
            lblPokegotchi1 = new Label();
            lblPokegotchi2 = new Label();
            lblPokegotchi1Gender = new Label();
            lblPokegotchi2Gender = new Label();
            lblPokegtochi1Level = new Label();
            lblPokegotchi2Level = new Label();
            lblBreedHeading = new Label();
            psbBreedingProgress = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pb_Pokegotchi1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Heart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Pokegotchi2).BeginInit();
            pnl_Breed.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Franklin Gothic Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.Location = new Point(672, 58);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(116, 30);
            btn_Back.TabIndex = 0;
            btn_Back.Text = "Zurück";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // pb_Pokegotchi1
            // 
            pb_Pokegotchi1.Cursor = Cursors.Hand;
            pb_Pokegotchi1.Image = Properties.Resources.venti;
            pb_Pokegotchi1.Location = new Point(12, 145);
            pb_Pokegotchi1.Name = "pb_Pokegotchi1";
            pb_Pokegotchi1.Size = new Size(205, 183);
            pb_Pokegotchi1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Pokegotchi1.TabIndex = 1;
            pb_Pokegotchi1.TabStop = false;
            // 
            // pb_Heart
            // 
            pb_Heart.Cursor = Cursors.Hand;
            pb_Heart.Image = Properties.Resources.Zucht_ICON;
            pb_Heart.Location = new Point(297, 158);
            pb_Heart.Name = "pb_Heart";
            pb_Heart.Size = new Size(203, 170);
            pb_Heart.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Heart.TabIndex = 2;
            pb_Heart.TabStop = false;
            // 
            // pb_Pokegotchi2
            // 
            pb_Pokegotchi2.Cursor = Cursors.Hand;
            pb_Pokegotchi2.Image = Properties.Resources.venti;
            pb_Pokegotchi2.Location = new Point(583, 145);
            pb_Pokegotchi2.Name = "pb_Pokegotchi2";
            pb_Pokegotchi2.Size = new Size(205, 183);
            pb_Pokegotchi2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Pokegotchi2.TabIndex = 3;
            pb_Pokegotchi2.TabStop = false;
            // 
            // pnl_Breed
            // 
            pnl_Breed.BackColor = Color.FromArgb(147, 13, 13);
            pnl_Breed.Controls.Add(lblBreedHeading);
            pnl_Breed.Controls.Add(btn_Back);
            pnl_Breed.Dock = DockStyle.Top;
            pnl_Breed.Location = new Point(0, 0);
            pnl_Breed.Name = "pnl_Breed";
            pnl_Breed.Size = new Size(800, 99);
            pnl_Breed.TabIndex = 4;
            // 
            // lblPokegotchi1
            // 
            lblPokegotchi1.AutoSize = true;
            lblPokegotchi1.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPokegotchi1.Location = new Point(18, 339);
            lblPokegotchi1.Name = "lblPokegotchi1";
            lblPokegotchi1.Size = new Size(36, 17);
            lblPokegotchi1.TabIndex = 5;
            lblPokegotchi1.Text = "Venti";
            // 
            // lblPokegotchi2
            // 
            lblPokegotchi2.AutoSize = true;
            lblPokegotchi2.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPokegotchi2.Location = new Point(583, 339);
            lblPokegotchi2.Name = "lblPokegotchi2";
            lblPokegotchi2.Size = new Size(36, 17);
            lblPokegotchi2.TabIndex = 7;
            lblPokegotchi2.Text = "Venti";
            // 
            // lblPokegotchi1Gender
            // 
            lblPokegotchi1Gender.AutoSize = true;
            lblPokegotchi1Gender.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPokegotchi1Gender.Location = new Point(18, 354);
            lblPokegotchi1Gender.Name = "lblPokegotchi1Gender";
            lblPokegotchi1Gender.Size = new Size(53, 17);
            lblPokegotchi1Gender.TabIndex = 8;
            lblPokegotchi1Gender.Text = "weiblich";
            // 
            // lblPokegotchi2Gender
            // 
            lblPokegotchi2Gender.AutoSize = true;
            lblPokegotchi2Gender.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPokegotchi2Gender.Location = new Point(583, 354);
            lblPokegotchi2Gender.Name = "lblPokegotchi2Gender";
            lblPokegotchi2Gender.Size = new Size(59, 17);
            lblPokegotchi2Gender.TabIndex = 9;
            lblPokegotchi2Gender.Text = "männlich";
            // 
            // lblPokegtochi1Level
            // 
            lblPokegtochi1Level.AutoSize = true;
            lblPokegtochi1Level.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPokegtochi1Level.Location = new Point(18, 369);
            lblPokegtochi1Level.Name = "lblPokegtochi1Level";
            lblPokegtochi1Level.Size = new Size(64, 17);
            lblPokegtochi1Level.TabIndex = 10;
            lblPokegtochi1Level.Text = "Lvl.: 3000";
            // 
            // lblPokegotchi2Level
            // 
            lblPokegotchi2Level.AutoSize = true;
            lblPokegotchi2Level.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPokegotchi2Level.Location = new Point(583, 369);
            lblPokegotchi2Level.Name = "lblPokegotchi2Level";
            lblPokegotchi2Level.Size = new Size(64, 17);
            lblPokegotchi2Level.TabIndex = 11;
            lblPokegotchi2Level.Text = "Lvl.: 3000";
            // 
            // lblBreedHeading
            // 
            lblBreedHeading.AutoSize = true;
            lblBreedHeading.Font = new Font("Franklin Gothic Book", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblBreedHeading.ForeColor = Color.White;
            lblBreedHeading.Location = new Point(12, 51);
            lblBreedHeading.Name = "lblBreedHeading";
            lblBreedHeading.Size = new Size(93, 37);
            lblBreedHeading.TabIndex = 0;
            lblBreedHeading.Text = "Zucht";
            // 
            // psbBreedingProgress
            // 
            psbBreedingProgress.ForeColor = Color.FromArgb(147, 13, 13);
            psbBreedingProgress.Location = new Point(297, 341);
            psbBreedingProgress.Name = "psbBreedingProgress";
            psbBreedingProgress.Size = new Size(203, 21);
            psbBreedingProgress.TabIndex = 12;
            // 
            // f_Breed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(psbBreedingProgress);
            Controls.Add(lblPokegotchi2Level);
            Controls.Add(lblPokegtochi1Level);
            Controls.Add(lblPokegotchi2Gender);
            Controls.Add(lblPokegotchi1Gender);
            Controls.Add(lblPokegotchi2);
            Controls.Add(lblPokegotchi1);
            Controls.Add(pnl_Breed);
            Controls.Add(pb_Pokegotchi2);
            Controls.Add(pb_Heart);
            Controls.Add(pb_Pokegotchi1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "f_Breed";
            Text = "f_Breed";
            ((System.ComponentModel.ISupportInitialize)pb_Pokegotchi1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Heart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Pokegotchi2).EndInit();
            pnl_Breed.ResumeLayout(false);
            pnl_Breed.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Back;
        private PictureBox pb_Pokegotchi1;
        private PictureBox pb_Heart;
        private PictureBox pb_Pokegotchi2;
        private Panel pnl_Breed;
        private Label lblBreedHeading;
        private Label lblPokegotchi1;
        private Label lblPokegotchi2;
        private Label lblPokegotchi1Gender;
        private Label lblPokegotchi2Gender;
        private Label lblPokegtochi1Level;
        private Label lblPokegotchi2Level;
        private ProgressBar psbBreedingProgress;
    }
}