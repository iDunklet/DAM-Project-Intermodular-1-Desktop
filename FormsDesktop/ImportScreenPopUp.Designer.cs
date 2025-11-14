namespace FormsDesktop
{
    partial class ImportScreenPopUp
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
            ButtonImportColors = new Button();
            ButtonImportCatRain = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ButtonImportColors
            // 
            ButtonImportColors.BackColor = Color.FromArgb(192, 255, 255);
            ButtonImportColors.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ButtonImportColors.Location = new Point(96, 129);
            ButtonImportColors.Name = "ButtonImportColors";
            ButtonImportColors.Size = new Size(210, 80);
            ButtonImportColors.TabIndex = 0;
            ButtonImportColors.Text = "Colors Forms";
            ButtonImportColors.UseVisualStyleBackColor = false;
            ButtonImportColors.Click += ButtonImportColors_Click;
            // 
            // ButtonImportCatRain
            // 
            ButtonImportCatRain.BackColor = Color.FromArgb(192, 255, 255);
            ButtonImportCatRain.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ButtonImportCatRain.Location = new Point(437, 129);
            ButtonImportCatRain.Name = "ButtonImportCatRain";
            ButtonImportCatRain.Size = new Size(210, 80);
            ButtonImportCatRain.TabIndex = 1;
            ButtonImportCatRain.Text = "Cat Rain";
            ButtonImportCatRain.UseVisualStyleBackColor = false;
            ButtonImportCatRain.Click += ButtonImportCatRain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(96, 32);
            label1.Name = "label1";
            label1.Size = new Size(551, 54);
            label1.TabIndex = 2;
            label1.Text = "Que juego deseas importar?";
            // 
            // ImportScreenPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(118, 195, 255);
            ClientSize = new Size(757, 250);
            Controls.Add(label1);
            Controls.Add(ButtonImportCatRain);
            Controls.Add(ButtonImportColors);
            Name = "ImportScreenPopUp";
            Text = "ImportScreenPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonImportColors;
        private Button ButtonImportCatRain;
        private Label label1;
    }
}