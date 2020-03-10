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
    public partial class Formcoeficient1 : Form
    {
        public Formcoeficient1()
        {
            InitializeComponent();
        }

        private void Formcoeficient1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarplataDataSet.coefficient". При необходимости она может быть перемещена или удалена.
            this.coefficientTableAdapter.Fill(this.zarplataDataSet.coefficient);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            coefficientTableAdapter.Update(zarplataDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form ifrm = new FormMeneger();
            ifrm.Show();
            this.Close();

        }
    }
}
