using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buricmarioVjezba
{
    public partial class FormStudenti : Form
    {
        public FormStudenti()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormStudenti_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta unos = new FormUnosNovogStudenta();
            unos.Show();
        }

        private void ButtonObrisiStudenta_Click(object sender, EventArgs e)
        {
            listBoxStudenti.ClearSelected();
        }

        private void listBoxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
