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
            this.btnWash = new System.Windows.Forms.Button();
            this.btnCuddle = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWash
            // 
            this.btnWash.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWash.Location = new System.Drawing.Point(84, 12);
            this.btnWash.Name = "btnWash";
            this.btnWash.Size = new System.Drawing.Size(172, 53);
            this.btnWash.TabIndex = 0;
            this.btnWash.Text = "Streicheln";
            this.btnWash.UseVisualStyleBackColor = true;
            // 
            // btnCuddle
            // 
            this.btnCuddle.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCuddle.Location = new System.Drawing.Point(442, 12);
            this.btnCuddle.Name = "btnCuddle";
            this.btnCuddle.Size = new System.Drawing.Size(172, 53);
            this.btnCuddle.TabIndex = 1;
            this.btnCuddle.Text = "Kuscheln";
            this.btnCuddle.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(815, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(172, 53);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Spielen";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(84, 531);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 37);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // f_Care
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokegotchi_SWP.Properties.Resources.bedroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 589);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnCuddle);
            this.Controls.Add(this.btnWash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "f_Care";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_Care";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnWash;
        private Button btnCuddle;
        private Button btnPlay;
        private Button btn_back;
    }
}