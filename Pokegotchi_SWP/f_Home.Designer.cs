namespace Pokegotchi_SWP
{
    partial class f_Home
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
            this.pbFavPokegotchi = new System.Windows.Forms.PictureBox();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnBreed = new System.Windows.Forms.Button();
            this.btnCare = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavPokegotchi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFavPokegotchi
            // 
            this.pbFavPokegotchi.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pbFavPokegotchi.Location = new System.Drawing.Point(448, 302);
            this.pbFavPokegotchi.Name = "pbFavPokegotchi";
            this.pbFavPokegotchi.Size = new System.Drawing.Size(292, 293);
            this.pbFavPokegotchi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFavPokegotchi.TabIndex = 0;
            this.pbFavPokegotchi.TabStop = false;
            // 
            // btnFight
            // 
            this.btnFight.BackColor = System.Drawing.Color.White;
            this.btnFight.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFight.Location = new System.Drawing.Point(106, 30);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(200, 58);
            this.btnFight.TabIndex = 1;
            this.btnFight.Text = "Kampf";
            this.btnFight.UseVisualStyleBackColor = false;
            // 
            // btnBreed
            // 
            this.btnBreed.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBreed.Location = new System.Drawing.Point(486, 30);
            this.btnBreed.Name = "btnBreed";
            this.btnBreed.Size = new System.Drawing.Size(200, 58);
            this.btnBreed.TabIndex = 2;
            this.btnBreed.Text = "Zucht";
            this.btnBreed.UseVisualStyleBackColor = true;
            // 
            // btnCare
            // 
            this.btnCare.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCare.Location = new System.Drawing.Point(866, 30);
            this.btnCare.Name = "btnCare";
            this.btnCare.Size = new System.Drawing.Size(200, 58);
            this.btnCare.TabIndex = 3;
            this.btnCare.Text = "Kümmern";
            this.btnCare.UseVisualStyleBackColor = true;
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShop.Location = new System.Drawing.Point(1004, 584);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(141, 38);
            this.btnShop.TabIndex = 4;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            // 
            // f_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pokegotchi_SWP.Properties.Resources.Livingroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 631);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnCare);
            this.Controls.Add(this.btnBreed);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.pbFavPokegotchi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "f_Home";
            this.Text = "Appartment";
            ((System.ComponentModel.ISupportInitialize)(this.pbFavPokegotchi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbFavPokegotchi;
        private Button btnFight;
        private Button btnBreed;
        private Button btnCare;
        private Button btnShop;
    }
}