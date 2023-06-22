namespace Pokegotchi_SWP
{
    partial class f_Care
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
            this.btnWash = new System.Windows.Forms.Button();
            this.btnCuddle = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pbPokegotchi = new System.Windows.Forms.PictureBox();
            this.tmWaiting = new System.Windows.Forms.Timer(this.components);
            this.lblFriendshiplevel = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWash
            // 
            this.btnWash.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWash.Location = new System.Drawing.Point(96, 16);
            this.btnWash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWash.Name = "btnWash";
            this.btnWash.Size = new System.Drawing.Size(197, 71);
            this.btnWash.TabIndex = 0;
            this.btnWash.Text = "Streicheln";
            this.btnWash.UseVisualStyleBackColor = true;
            this.btnWash.Click += new System.EventHandler(this.btnWash_Click);
            // 
            // btnCuddle
            // 
            this.btnCuddle.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCuddle.Location = new System.Drawing.Point(505, 16);
            this.btnCuddle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCuddle.Name = "btnCuddle";
            this.btnCuddle.Size = new System.Drawing.Size(197, 71);
            this.btnCuddle.TabIndex = 1;
            this.btnCuddle.Text = "Kuscheln";
            this.btnCuddle.UseVisualStyleBackColor = true;
            this.btnCuddle.Click += new System.EventHandler(this.btnCuddle_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(931, 16);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(197, 71);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Spielen";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(96, 708);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(144, 49);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pbPokegotchi
            // 
            this.pbPokegotchi.Image = global::Pokegotchi_SWP.Properties.Resources.venti;
            this.pbPokegotchi.Location = new System.Drawing.Point(376, 232);
            this.pbPokegotchi.Name = "pbPokegotchi";
            this.pbPokegotchi.Size = new System.Drawing.Size(444, 410);
            this.pbPokegotchi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokegotchi.TabIndex = 4;
            this.pbPokegotchi.TabStop = false;
            // 
            // tmWaiting
            // 
            this.tmWaiting.Tick += new System.EventHandler(this.tmWaiting_Tick);
            // 
            // lblFriendshiplevel
            // 
            this.lblFriendshiplevel.AutoSize = true;
            this.lblFriendshiplevel.BackColor = System.Drawing.Color.RosyBrown;
            this.lblFriendshiplevel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFriendshiplevel.ForeColor = System.Drawing.Color.Black;
            this.lblFriendshiplevel.Location = new System.Drawing.Point(113, 135);
            this.lblFriendshiplevel.Name = "lblFriendshiplevel";
            this.lblFriendshiplevel.Size = new System.Drawing.Size(180, 25);
            this.lblFriendshiplevel.TabIndex = 5;
            this.lblFriendshiplevel.Text = "Freundschaftsstufe:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.Color.RosyBrown;
            this.lblTimeLeft.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeLeft.ForeColor = System.Drawing.Color.Black;
            this.lblTimeLeft.Location = new System.Drawing.Point(113, 175);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(165, 25);
            this.lblTimeLeft.TabIndex = 6;
            this.lblTimeLeft.Text = "Verbleibende Zeit:";
            // 
            // f_Care
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokegotchi_SWP.Properties.Resources.bedroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 785);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblFriendshiplevel);
            this.Controls.Add(this.pbPokegotchi);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnCuddle);
            this.Controls.Add(this.btnWash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "f_Care";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Care";
            ((System.ComponentModel.ISupportInitialize)(this.pbPokegotchi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWash;
        private Button btnCuddle;
        private Button btnPlay;
        private Button btn_back;
        private PictureBox pbPokegotchi;
        private System.Windows.Forms.Timer tmWaiting;
        private Label lblFriendshiplevel;
        private Label lblTimeLeft;
    }
}