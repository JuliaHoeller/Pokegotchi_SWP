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
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(36, 403);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(116, 30);
            btn_Back.TabIndex = 0;
            btn_Back.Text = "Zurück";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // f_Breed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Back);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "f_Breed";
            Text = "f_Breed";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Back;
    }
}