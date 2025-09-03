namespace DsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            Selecione = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(513, 22);
            button3.Name = "button3";
            button3.Size = new Size(160, 63);
            button3.TabIndex = 2;
            button3.Text = "Música";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(43, 22);
            button1.Name = "button1";
            button1.Size = new Size(160, 63);
            button1.TabIndex = 3;
            button1.Text = "Cantor/Banda";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(279, 22);
            button2.Name = "button2";
            button2.Size = new Size(160, 63);
            button2.TabIndex = 4;
            button2.Text = "Álbum";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Selecione
            // 
            Selecione.AutoSize = true;
            Selecione.Font = new Font("Segoe UI", 33F);
            Selecione.Location = new Point(342, 95);
            Selecione.Name = "Selecione";
            Selecione.Size = new Size(412, 60);
            Selecione.TabIndex = 5;
            Selecione.Text = "Selecione um botão";
            Selecione.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(192, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 97);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1112, 541);
            Controls.Add(groupBox1);
            Controls.Add(Selecione);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private Label Selecione;
        private GroupBox groupBox1;
    }
}
