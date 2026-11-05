namespace Cifrario_parola
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
            btn_decifra = new Button();
            btn_cifra = new Button();
            lbl_decifrato = new Label();
            lbl_chiave_2 = new Label();
            lbl_stringa_2 = new Label();
            lbl_chiave_1 = new Label();
            lbl_stringa_1 = new Label();
            txt_chiave_1 = new TextBox();
            txt_chiave_2 = new TextBox();
            txt_decifrare = new TextBox();
            txt_cifrare = new TextBox();
            lbl_cifrato = new Label();
            SuspendLayout();
            // 
            // btn_decifra
            // 
            btn_decifra.Location = new Point(500, 292);
            btn_decifra.Name = "btn_decifra";
            btn_decifra.Size = new Size(75, 23);
            btn_decifra.TabIndex = 1;
            btn_decifra.Text = "Decifra";
            btn_decifra.UseVisualStyleBackColor = true;
            btn_decifra.Click += btn_decifra_Click;
            // 
            // btn_cifra
            // 
            btn_cifra.Location = new Point(86, 296);
            btn_cifra.Name = "btn_cifra";
            btn_cifra.Size = new Size(75, 23);
            btn_cifra.TabIndex = 2;
            btn_cifra.Text = "Cifra";
            btn_cifra.UseVisualStyleBackColor = true;
            btn_cifra.Click += btn_cifra_Click;
            // 
            // lbl_decifrato
            // 
            lbl_decifrato.AutoSize = true;
            lbl_decifrato.Location = new Point(606, 300);
            lbl_decifrato.Name = "lbl_decifrato";
            lbl_decifrato.Size = new Size(116, 15);
            lbl_decifrato.TabIndex = 3;
            lbl_decifrato.Text = "La parola decifrata è:";
            // 
            // lbl_chiave_2
            // 
            lbl_chiave_2.AutoSize = true;
            lbl_chiave_2.Location = new Point(500, 207);
            lbl_chiave_2.Name = "lbl_chiave_2";
            lbl_chiave_2.Size = new Size(82, 15);
            lbl_chiave_2.TabIndex = 4;
            lbl_chiave_2.Text = "Inserire chiave";
            // 
            // lbl_stringa_2
            // 
            lbl_stringa_2.AutoSize = true;
            lbl_stringa_2.Location = new Point(500, 84);
            lbl_stringa_2.Name = "lbl_stringa_2";
            lbl_stringa_2.Size = new Size(84, 15);
            lbl_stringa_2.TabIndex = 5;
            lbl_stringa_2.Text = "Inserire stringa";
            // 
            // lbl_chiave_1
            // 
            lbl_chiave_1.AutoSize = true;
            lbl_chiave_1.Location = new Point(86, 211);
            lbl_chiave_1.Name = "lbl_chiave_1";
            lbl_chiave_1.Size = new Size(94, 15);
            lbl_chiave_1.TabIndex = 6;
            lbl_chiave_1.Text = "Inserire la chiave";
            // 
            // lbl_stringa_1
            // 
            lbl_stringa_1.AutoSize = true;
            lbl_stringa_1.Location = new Point(86, 88);
            lbl_stringa_1.Name = "lbl_stringa_1";
            lbl_stringa_1.Size = new Size(84, 15);
            lbl_stringa_1.TabIndex = 7;
            lbl_stringa_1.Text = "Inserire stringa";
            // 
            // txt_chiave_1
            // 
            txt_chiave_1.Location = new Point(219, 207);
            txt_chiave_1.Name = "txt_chiave_1";
            txt_chiave_1.Size = new Size(100, 23);
            txt_chiave_1.TabIndex = 8;
            // 
            // txt_chiave_2
            // 
            txt_chiave_2.Location = new Point(606, 208);
            txt_chiave_2.Name = "txt_chiave_2";
            txt_chiave_2.Size = new Size(100, 23);
            txt_chiave_2.TabIndex = 9;
            // 
            // txt_decifrare
            // 
            txt_decifrare.Location = new Point(606, 84);
            txt_decifrare.Name = "txt_decifrare";
            txt_decifrare.Size = new Size(100, 23);
            txt_decifrare.TabIndex = 10;
            // 
            // txt_cifrare
            // 
            txt_cifrare.Location = new Point(219, 84);
            txt_cifrare.Name = "txt_cifrare";
            txt_cifrare.Size = new Size(100, 23);
            txt_cifrare.TabIndex = 11;
            // 
            // lbl_cifrato
            // 
            lbl_cifrato.AutoSize = true;
            lbl_cifrato.Location = new Point(219, 300);
            lbl_cifrato.Name = "lbl_cifrato";
            lbl_cifrato.Size = new Size(106, 15);
            lbl_cifrato.TabIndex = 12;
            lbl_cifrato.Text = "La parola  cifrate è:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_cifrato);
            Controls.Add(txt_cifrare);
            Controls.Add(txt_decifrare);
            Controls.Add(txt_chiave_2);
            Controls.Add(txt_chiave_1);
            Controls.Add(lbl_stringa_1);
            Controls.Add(lbl_chiave_1);
            Controls.Add(lbl_stringa_2);
            Controls.Add(lbl_chiave_2);
            Controls.Add(lbl_decifrato);
            Controls.Add(btn_cifra);
            Controls.Add(btn_decifra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_decifra;
        private Button btn_cifra;
        private Label lbl_decifrato;
        private Label lbl_chiave_2;
        private Label lbl_stringa_2;
        private Label lbl_chiave_1;
        private Label lbl_stringa_1;
        private TextBox txt_chiave_1;
        private TextBox txt_chiave_2;
        private TextBox txt_decifrare;
        private TextBox txt_cifrare;
        private Label lbl_cifrato;
    }
}
