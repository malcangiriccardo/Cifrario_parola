namespace Cifrario_parola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cifra_Click(object sender, EventArgs e)
        {
            int chiave, i, n_lettera;
            string testo, testo_cifrato = "";

            testo = txt_cifrare.Text;
            chiave = Convert.ToInt32(txt_chiave_1.Text);

            for (i = 0; i < testo.Length; i++)
            {
                n_lettera = Convert.ToInt32(testo[i]);

                if (n_lettera >= 65 && n_lettera <= 90)
                {
                    n_lettera -= 64;

                    n_lettera += chiave;

                    n_lettera = n_lettera % 26;

                    n_lettera += 64;

                }
                else if (n_lettera >= 97 && n_lettera <= 122)
                {
                    n_lettera -= 96;

                    n_lettera += chiave;

                    n_lettera = n_lettera % 26;

                    n_lettera += 96;

                }

                testo_cifrato = testo_cifrato + Convert.ToChar(n_lettera);
            }
            lbl_cifrato.Text = "Il testo cifrato è: " + testo_cifrato;
        }

        private void btn_decifra_Click(object sender, EventArgs e)
        {
            int chiave, i, n_lettera;
            string testo, testo_decifrato = "";

            testo = txt_decifrare.Text;
            chiave = Convert.ToInt32(txt_chiave_2.Text);

            for (i = 0; i < testo.Length; i++)
            {
                n_lettera = Convert.ToInt32(testo[i]);

                if (n_lettera >= 65 && n_lettera <= 90)
                {
                    n_lettera -= 64;

                    n_lettera = n_lettera % 26;

                    n_lettera += 64;

                    n_lettera -= chiave;

                }
                else if (n_lettera >= 97 && n_lettera <= 122)
                {

                    n_lettera -= 96;

                    n_lettera = n_lettera % 26;

                    n_lettera += 96;

                    n_lettera -= chiave;

                }

                testo_decifrato = testo_decifrato + Convert.ToChar(n_lettera);
            }
            lbl_decifrato.Text = "Il testo decifrato è: " + testo_decifrato;
        }
    }
}
