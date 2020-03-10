using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oplata
{
    public partial class Formcoeficient : Form
    {
        public Formcoeficient()
        {
            InitializeComponent();
        }

        private void coefficientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coefficientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zarplataDataSet);

        }

        private void Formcoeficient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarplataDataSet.coefficient". При необходимости она может быть перемещена или удалена.
            this.coefficientTableAdapter.Fill(this.zarplataDataSet.coefficient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormMeneger();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifr = new Formcoeficient1();
            ifr.Left = this.Left;
            ifr.Top = this.Top;
            ifr.Show();
            this.Hide();
        }
    }
}
