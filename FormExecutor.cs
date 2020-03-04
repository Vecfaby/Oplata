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

        private void executorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.executorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zarplataDataSet);

        }

        private void FormExecutor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarplataDataSet.Executor". При необходимости она может быть перемещена или удалена.
            this.executorTableAdapter.Fill(this.zarplataDataSet.Executor);

        }
    }
}
