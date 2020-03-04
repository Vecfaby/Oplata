using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oplata
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = textBoxLogin.Text;
                string passUser = textBoxPass.Text;
                ClassIniDataBase db = new ClassIniDataBase();
                DataTable table = new DataTable();


                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandagent = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role= 'manager'", db.GetConnection());
                commandagent.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandagent.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandagent;
                adapter.Fill(table);
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand commandclient = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role = 'executor'", db.GetConnection());
                commandclient.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandclient.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter1.SelectCommand = commandclient;
                adapter1.Fill(table1);
                if (table.Rows.Count > 0)
                {
                    Form ifrm = new FormMeneger();
                    ifrm.Left = this.Left;
                    ifrm.Top = this.Top;
                    ifrm.Show();
                    this.Hide();
                }
                else
                {
                    if (table1.Rows.Count > 0)
                    {
                        Form efrm = new FormExecutor();
                        efrm.Show();
                        efrm.Top = this.Top;
                        efrm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Не верный логин или пароль");
                        textBoxLogin.Clear();
                        textBoxPass.Clear();
                    }
                }
            }
            finally { }

        }

        private void FormAuto_Load(object sender, EventArgs e)
        {

        }
    }
    }



