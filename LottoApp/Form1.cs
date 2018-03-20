using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoApp
{
    public partial class FrmLotto : Form
    {
        private Lotto lotto;

        public FrmLotto()
        {
            InitializeComponent();
            lotto = new Lotto();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLotto_Load(object sender, EventArgs e)
        {

        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();

            vrijednosti.Add(textBoxUplaceniBroj1.Text);
            vrijednosti.Add(textBoxUplaceniBroj2.Text);
            vrijednosti.Add(textBoxUplaceniBroj3.Text);
            vrijednosti.Add(textBoxUplaceniBroj4.Text);
            vrijednosti.Add(textBoxUplaceniBroj5.Text);
            vrijednosti.Add(textBoxUplaceniBroj6.Text);
            vrijednosti.Add(textBoxUplaceniBroj7.Text);

            bool ispravnaKombinacija = lotto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                btnOdigraj.Enabled = true;
            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Unesena neispravna kombinacija brojeva!");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            lotto.GenerirajDobitnuKombinaciju();

            textBoxDobitniBroj1.Text = lotto.DobitniBrojevi[0].ToString();
            textBoxDobitniBroj2.Text = lotto.DobitniBrojevi[1].ToString();
            textBoxDobitniBroj3.Text = lotto.DobitniBrojevi[2].ToString();
            textBoxDobitniBroj4.Text = lotto.DobitniBrojevi[3].ToString();
            textBoxDobitniBroj5.Text = lotto.DobitniBrojevi[4].ToString();
            textBoxDobitniBroj6.Text = lotto.DobitniBrojevi[5].ToString();
            textBoxDobitniBroj7.Text = lotto.DobitniBrojevi[6].ToString();

            int brojPogodaka = lotto.IzracunajBrojPogodaka();
            lblBrojPogodaka.Text = brojPogodaka.ToString();
        }
    }
}
