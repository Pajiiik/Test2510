namespace Test2510
{
    partial class Ukoncit
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
            label2 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(356, 35);
            label2.TabIndex = 0;
            label2.Text = "Opravdu chcete ukonšit hru?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 44);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(45, 144);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 5;
            button2.Text = "Ano";
            button2.UseVisualStyleBackColor = true;
            button2.MouseEnter += button2_MouseEnter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(260, 144);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 6;
            button1.Text = "Ne";
            button1.UseVisualStyleBackColor = true;
            // 
            // Ukoncit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(407, 221);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ukoncit";
            Text = "Ukoncit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button button2;
        private Button button1;
    }
}