namespace Pokegotchi_SWP
{
    partial class f_Credits
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
            this.pnlCredits = new System.Windows.Forms.Panel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblJulia = new System.Windows.Forms.Label();
            this.lblRaphael = new System.Windows.Forms.Label();
            this.lblJaqueline = new System.Windows.Forms.Label();
            this.pnlCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCredits
            // 
            this.pnlCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(162)))), ((int)(((byte)(179)))));
            this.pnlCredits.Controls.Add(this.lblJaqueline);
            this.pnlCredits.Controls.Add(this.lblRaphael);
            this.pnlCredits.Controls.Add(this.lblJulia);
            this.pnlCredits.Controls.Add(this.lblCredits);
            this.pnlCredits.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCredits.Location = new System.Drawing.Point(0, 0);
            this.pnlCredits.Name = "pnlCredits";
            this.pnlCredits.Size = new System.Drawing.Size(221, 484);
            this.pnlCredits.TabIndex = 0;
            this.pnlCredits.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCredits_Paint);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Franklin Gothic Book", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCredits.ForeColor = System.Drawing.Color.White;
            this.lblCredits.Location = new System.Drawing.Point(30, 24);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(155, 52);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Credits";
            // 
            // lblJulia
            // 
            this.lblJulia.AutoSize = true;
            this.lblJulia.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJulia.ForeColor = System.Drawing.Color.White;
            this.lblJulia.Location = new System.Drawing.Point(113, 137);
            this.lblJulia.Name = "lblJulia";
            this.lblJulia.Size = new System.Drawing.Size(96, 24);
            this.lblJulia.TabIndex = 1;
            this.lblJulia.Text = "Julia Höller";
            // 
            // lblRaphael
            // 
            this.lblRaphael.AutoSize = true;
            this.lblRaphael.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRaphael.ForeColor = System.Drawing.Color.White;
            this.lblRaphael.Location = new System.Drawing.Point(63, 337);
            this.lblRaphael.Name = "lblRaphael";
            this.lblRaphael.Size = new System.Drawing.Size(146, 24);
            this.lblRaphael.TabIndex = 2;
            this.lblRaphael.Text = "Raphael Staffner";
            // 
            // lblJaqueline
            // 
            this.lblJaqueline.AutoSize = true;
            this.lblJaqueline.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJaqueline.ForeColor = System.Drawing.Color.White;
            this.lblJaqueline.Location = new System.Drawing.Point(67, 228);
            this.lblJaqueline.Name = "lblJaqueline";
            this.lblJaqueline.Size = new System.Drawing.Size(142, 24);
            this.lblJaqueline.TabIndex = 3;
            this.lblJaqueline.Text = "Jaqueline Pfister";
            // 
            // f_Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 484);
            this.Controls.Add(this.pnlCredits);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "f_Credits";
            this.Text = "Credits";
            this.pnlCredits.ResumeLayout(false);
            this.pnlCredits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCredits;
        private Label lblCredits;
        private Label lblJaqueline;
        private Label lblRaphael;
        private Label lblJulia;
    }
}