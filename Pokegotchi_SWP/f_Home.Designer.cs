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
            pbFavPokegotchi = new PictureBox();
            btnFight = new Button();
            btnBreed = new Button();
            btnCare = new Button();
            btnShop = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFavPokegotchi).BeginInit();
            SuspendLayout();
            // 
            // pbFavPokegotchi
            // 
            pbFavPokegotchi.Image = Properties.Resources.venti;
            pbFavPokegotchi.Location = new Point(436, 283);
            pbFavPokegotchi.Name = "pbFavPokegotchi";
            pbFavPokegotchi.Size = new Size(292, 293);
            pbFavPokegotchi.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavPokegotchi.TabIndex = 0;
            pbFavPokegotchi.TabStop = false;
            // 
            // btnFight
            // 
            btnFight.BackColor = Color.White;
            btnFight.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFight.Location = new Point(106, 30);
            btnFight.Name = "btnFight";
            btnFight.Size = new Size(200, 58);
            btnFight.TabIndex = 1;
            btnFight.Text = "Kampf";
            btnFight.UseVisualStyleBackColor = false;
            btnFight.Click += btnFight_Click;
            // 
            // btnBreed
            // 
            btnBreed.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBreed.Location = new Point(486, 30);
            btnBreed.Name = "btnBreed";
            btnBreed.Size = new Size(200, 58);
            btnBreed.TabIndex = 2;
            btnBreed.Text = "Zucht";
            btnBreed.UseVisualStyleBackColor = true;
            btnBreed.Click += btnBreed_Click;
            // 
            // btnCare
            // 
            btnCare.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCare.Location = new Point(866, 30);
            btnCare.Name = "btnCare";
            btnCare.Size = new Size(200, 58);
            btnCare.TabIndex = 3;
            btnCare.Text = "Kümmern";
            btnCare.UseVisualStyleBackColor = true;
            btnCare.Click += btnCare_Click;
            // 
            // btnShop
            // 
            btnShop.Font = new Font("Franklin Gothic Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnShop.Location = new Point(1004, 584);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(141, 38);
            btnShop.TabIndex = 4;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.Location = new Point(115, 582);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(117, 37);
            btn_back.TabIndex = 5;
            btn_back.Text = "zurück";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // f_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Livingroom;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1173, 631);
            Controls.Add(btn_back);
            Controls.Add(btnShop);
            Controls.Add(btnCare);
            Controls.Add(btnBreed);
            Controls.Add(btnFight);
            Controls.Add(pbFavPokegotchi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "f_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appartment";
            ((System.ComponentModel.ISupportInitialize)pbFavPokegotchi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbFavPokegotchi;
        private Button btnFight;
        private Button btnBreed;
        private Button btnCare;
        private Button btnShop;
        private Button btn_back;
    }
}