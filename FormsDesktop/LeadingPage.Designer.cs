namespace FormsDesktop
{
    partial class LeadingPage
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(500, 643);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 71);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 234, 255);
            button1.Image = Properties.Resources.icon_buton_lapiz_1_;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(65, 65);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 234, 255);
            button2.Image = Properties.Resources.icon_buton_graficos_1_;
            button2.Location = new Point(74, 3);
            button2.Name = "button2";
            button2.Size = new Size(65, 65);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(227, 234, 255);
            button3.Image = Properties.Resources.icon_buton_importar_1_;
            button3.Location = new Point(145, 3);
            button3.Name = "button3";
            button3.Size = new Size(65, 65);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(12, 615);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 10);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(12, 720);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 10);
            panel2.TabIndex = 2;
            // 
            // LeadingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 104, 156);
            ClientSize = new Size(1184, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "LeadingPage";
            Text = "LeadingPage";
            Load += LeadingPage_Load;
            Resize += LeadingPage_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
    }
}