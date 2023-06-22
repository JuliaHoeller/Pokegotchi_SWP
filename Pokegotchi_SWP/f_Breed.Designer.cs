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
            this.btn_Back = new System.Windows.Forms.Button();
            this.pb_Pokegotchi1 = new System.Windows.Forms.PictureBox();
            this.pb_Heart = new System.Windows.Forms.PictureBox();
            this.pb_Pokegotchi2 = new System.Windows.Forms.PictureBox();
            this.pnl_Breed = new System.Windows.Forms.Panel();
            this.lblBreedHeading = new System.Windows.Forms.Label();
            this.lblPokegotchi1 = new System.Windows.Forms.Label();
            this.lblPokegotchi2 = new System.Windows.Forms.Label();
            this.lblPokegotchi1Gender = new System.Windows.Forms.Label();
            this.lblPokegotchi2Gender = new System.Windows.Forms.Label();
            this.lblPokegtochi1Level = new System.Windows.Forms.Label();
            this.lblPokegotchi2Level = new System.Windows.Forms.Label();
            this.psbBreedingProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pokegotchi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pokegotchi2)).BeginInit();
            this.pnl_Breed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(768, 77);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(133, 40);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Zurück";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click_1);
            // 
            // pb_Pokegotchi1
            // 
            this.pb_Pokegotchi1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Pokegotchi1.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pb_Pokegotchi1.Location = new System.Drawing.Point(14, 193);
            this.pb_Pokegotchi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_Pokegotchi1.Name = "pb_Pokegotchi1";
            this.pb_Pokegotchi1.Size = new System.Drawing.Size(234, 244);
            this.pb_Pokegotchi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Pokegotchi1.TabIndex = 1;
            this.pb_Pokegotchi1.TabStop = false;
            // 
            // pb_Heart
            // 
            this.pb_Heart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Heart.Image = global::Pokegotchi_SWP.Properties.Resources.Zucht_ICON;
            this.pb_Heart.Location = new System.Drawing.Point(339, 211);
            this.pb_Heart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_Heart.Name = "pb_Heart";
            this.pb_Heart.Size = new System.Drawing.Size(232, 227);
            this.pb_Heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Heart.TabIndex = 2;
            this.pb_Heart.TabStop = false;
            // 
            // pb_Pokegotchi2
            // 
            this.pb_Pokegotchi2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Pokegotchi2.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pb_Pokegotchi2.Location = new System.Drawing.Point(666, 193);
            this.pb_Pokegotchi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_Pokegotchi2.Name = "pb_Pokegotchi2";
            this.pb_Pokegotchi2.Size = new System.Drawing.Size(234, 244);
            this.pb_Pokegotchi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Pokegotchi2.TabIndex = 3;
            this.pb_Pokegotchi2.TabStop = false;
            // 
            // pnl_Breed
            // 
            this.pnl_Breed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnl_Breed.Controls.Add(this.lblBreedHeading);
            this.pnl_Breed.Controls.Add(this.btn_Back);
            this.pnl_Breed.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Breed.Location = new System.Drawing.Point(0, 0);
            this.pnl_Breed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Breed.Name = "pnl_Breed";
            this.pnl_Breed.Size = new System.Drawing.Size(914, 132);
            this.pnl_Breed.TabIndex = 4;
            // 
            // lblBreedHeading
            // 
            this.lblBreedHeading.AutoSize = true;
            this.lblBreedHeading.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBreedHeading.ForeColor = System.Drawing.Color.White;
            this.lblBreedHeading.Location = new System.Drawing.Point(14, 68);
            this.lblBreedHeading.Name = "lblBreedHeading";
            this.lblBreedHeading.Size = new System.Drawing.Size(116, 47);
            this.lblBreedHeading.TabIndex = 0;
            this.lblBreedHeading.Text = "Zucht";
            // 
            // lblPokegotchi1
            // 
            this.lblPokegotchi1.AutoSize = true;
            this.lblPokegotchi1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPokegotchi1.Location = new System.Drawing.Point(21, 452);
            this.lblPokegotchi1.Name = "lblPokegotchi1";
            this.lblPokegotchi1.Size = new System.Drawing.Size(46, 21);
            this.lblPokegotchi1.TabIndex = 5;
            this.lblPokegotchi1.Text = "Venti";
            // 
            // lblPokegotchi2
            // 
            this.lblPokegotchi2.AutoSize = true;
            this.lblPokegotchi2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPokegotchi2.Location = new System.Drawing.Point(666, 452);
            this.lblPokegotchi2.Name = "lblPokegotchi2";
            this.lblPokegotchi2.Size = new System.Drawing.Size(46, 21);
            this.lblPokegotchi2.TabIndex = 7;
            this.lblPokegotchi2.Text = "Venti";
            // 
            // lblPokegotchi1Gender
            // 
            this.lblPokegotchi1Gender.AutoSize = true;
            this.lblPokegotchi1Gender.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPokegotchi1Gender.Location = new System.Drawing.Point(21, 472);
            this.lblPokegotchi1Gender.Name = "lblPokegotchi1Gender";
            this.lblPokegotchi1Gender.Size = new System.Drawing.Size(68, 21);
            this.lblPokegotchi1Gender.TabIndex = 8;
            this.lblPokegotchi1Gender.Text = "weiblich";
            // 
            // lblPokegotchi2Gender
            // 
            this.lblPokegotchi2Gender.AutoSize = true;
            this.lblPokegotchi2Gender.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPokegotchi2Gender.Location = new System.Drawing.Point(666, 472);
            this.lblPokegotchi2Gender.Name = "lblPokegotchi2Gender";
            this.lblPokegotchi2Gender.Size = new System.Drawing.Size(76, 21);
            this.lblPokegotchi2Gender.TabIndex = 9;
            this.lblPokegotchi2Gender.Text = "männlich";
            // 
            // lblPokegtochi1Level
            // 
            this.lblPokegtochi1Level.AutoSize = true;
            this.lblPokegtochi1Level.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPokegtochi1Level.Location = new System.Drawing.Point(21, 492);
            this.lblPokegtochi1Level.Name = "lblPokegtochi1Level";
            this.lblPokegtochi1Level.Size = new System.Drawing.Size(82, 21);
            this.lblPokegtochi1Level.TabIndex = 10;
            this.lblPokegtochi1Level.Text = "Lvl.: 3000";
            // 
            // lblPokegotchi2Level
            // 
            this.lblPokegotchi2Level.AutoSize = true;
            this.lblPokegotchi2Level.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPokegotchi2Level.Location = new System.Drawing.Point(666, 492);
            this.lblPokegotchi2Level.Name = "lblPokegotchi2Level";
            this.lblPokegotchi2Level.Size = new System.Drawing.Size(82, 21);
            this.lblPokegotchi2Level.TabIndex = 11;
            this.lblPokegotchi2Level.Text = "Lvl.: 3000";
            // 
            // psbBreedingProgress
            // 
            this.psbBreedingProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.psbBreedingProgress.Location = new System.Drawing.Point(339, 455);
            this.psbBreedingProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.psbBreedingProgress.Name = "psbBreedingProgress";
            this.psbBreedingProgress.Size = new System.Drawing.Size(232, 28);
            this.psbBreedingProgress.TabIndex = 12;
            // 
            // f_Breed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.psbBreedingProgress);
            this.Controls.Add(this.lblPokegotchi2Level);
            this.Controls.Add(this.lblPokegtochi1Level);
            this.Controls.Add(this.lblPokegotchi2Gender);
            this.Controls.Add(this.lblPokegotchi1Gender);
            this.Controls.Add(this.lblPokegotchi2);
            this.Controls.Add(this.lblPokegotchi1);
            this.Controls.Add(this.pnl_Breed);
            this.Controls.Add(this.pb_Pokegotchi2);
            this.Controls.Add(this.pb_Heart);
            this.Controls.Add(this.pb_Pokegotchi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "f_Breed";
            this.Text = "Zucht";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pokegotchi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pokegotchi2)).EndInit();
            this.pnl_Breed.ResumeLayout(false);
            this.pnl_Breed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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