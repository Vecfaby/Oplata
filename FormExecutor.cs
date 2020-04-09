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
    public partial class FormExecutor : Form
    {
        public FormExecutor()
        {
            InitializeComponent();
        }

        private void FormExecutor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarplataDataSet1.Executor". При необходимости она может быть перемещена или удалена.
            this.executorTableAdapter.Fill(this.zarplataDataSet1.Executor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarplataDataSet1.Meneger". При необходимости она может быть перемещена или удалена.
            this.menegerTableAdapter.Fill(this.zarplataDataSet1.Meneger);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form ifrm = new FormMeneger();
            ifrm.Show();
            this.Close();
        }
    }
}
