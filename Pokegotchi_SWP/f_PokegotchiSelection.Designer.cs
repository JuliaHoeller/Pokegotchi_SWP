namespace Pokegotchi_SWP
{
    partial class f_PokegotchiSelection
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
            pbPokegotchi1 = new PictureBox();
            pbPokegotchi4 = new PictureBox();
            pbPokegotchi3 = new PictureBox();
            pbPokegotchi2 = new PictureBox();
            lblPokegotchi1Name = new Label();
            lblPokegotchi1Level = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi2).BeginInit();
            SuspendLayout();
            // 
            // pbPokegotchi1
            // 
            pbPokegotchi1.Image = Properties.Resources.venti;
            pbPokegotchi1.Location = new Point(427, 12);
            pbPokegotchi1.Name = "pbPokegotchi1";
            pbPokegotchi1.Size = new Size(147, 99);
            pbPokegotchi1.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokegotchi1.TabIndex = 0;
            pbPokegotchi1.TabStop = false;
            // 
            // pbPokegotchi4
            // 
            pbPokegotchi4.Image = Properties.Resources.venti;
            pbPokegotchi4.Location = new Point(641, 164);
            pbPokegotchi4.Name = "pbPokegotchi4";
            pbPokegotchi4.Size = new Size(147, 99);
            pbPokegotchi4.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokegotchi4.TabIndex = 1;
            pbPokegotchi4.TabStop = false;
            // 
            // pbPokegotchi3
            // 
            pbPokegotchi3.Image = Properties.Resources.venti;
            pbPokegotchi3.Location = new Point(427, 164);
            pbPokegotchi3.Name = "pbPokegotchi3";
            pbPokegotchi3.Size = new Size(147, 99);
            pbPokegotchi3.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokegotchi3.TabIndex = 2;
            pbPokegotchi3.TabStop = false;
            // 
            // pbPokegotchi2
            // 
            pbPokegotchi2.Image = Properties.Resources.venti;
            pbPokegotchi2.Location = new Point(641, 12);
            pbPokegotchi2.Name = "pbPokegotchi2";
            pbPokegotchi2.Size = new Size(147, 99);
            pbPokegotchi2.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokegotchi2.TabIndex = 3;
            pbPokegotchi2.TabStop = false;
            // 
            // lblPokegotchi1Name
            // 
            lblPokegotchi1Name.AutoSize = true;
            lblPokegotchi1Name.Location = new Point(427, 114);
            lblPokegotchi1Name.Name = "lblPokegotchi1Name";
            lblPokegotchi1Name.Size = new Size(33, 15);
            lblPokegotchi1Name.TabIndex = 4;
            lblPokegotchi1Name.Text = "Venti";
            // 
            // lblPokegotchi1Level
            // 
            lblPokegotchi1Level.AutoSize = true;
            lblPokegotchi1Level.Location = new Point(427, 129);
            lblPokegotchi1Level.Name = "lblPokegotchi1Level";
            lblPokegotchi1Level.Size = new Size(51, 15);
            lblPokegotchi1Level.TabIndex = 5;
            lblPokegotchi1Level.Text = "Lvl: 3000";
            // 
            // f_PokegotchiSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 337);
            Controls.Add(lblPokegotchi1Level);
            Controls.Add(lblPokegotchi1Name);
            Controls.Add(pbPokegotchi2);
            Controls.Add(pbPokegotchi3);
            Controls.Add(pbPokegotchi4);
            Controls.Add(pbPokegotchi1);
            Name = "f_PokegotchiSelection";
            Text = "f_PokegotchiSelection";
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPokegotchi2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPokegotchi1;
        private PictureBox pbPokegotchi4;
        private PictureBox pbPokegotchi3;
        private PictureBox pbPokegotchi2;
        private Label lblPokegotchi1Name;
        private Label lblPokegotchi1Level;
    }
}