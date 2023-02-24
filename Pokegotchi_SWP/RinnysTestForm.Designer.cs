namespace Pokegotchi_SWP
{
    partial class RinnysTestForm
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
            this.btn_showattacks = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_showattacks
            // 
            this.btn_showattacks.Location = new System.Drawing.Point(12, 12);
            this.btn_showattacks.Name = "btn_showattacks";
            this.btn_showattacks.Size = new System.Drawing.Size(154, 42);
            this.btn_showattacks.TabIndex = 0;
            this.btn_showattacks.Text = "Show Attacken";
            this.btn_showattacks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(714, 355);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // RinnysTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_showattacks);
            this.Name = "RinnysTestForm";
            this.Text = "RinnysTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_showattacks;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}