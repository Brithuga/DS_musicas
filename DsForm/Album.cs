using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DsForm
{
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=DS; Uid=root; Pwd=root";

            string query = "Select cd_album, nm_album, dt_lancamento from album order by dt_lancamento;";

            using (MySqlConnection con = new MySqlConnection(conexao))

            {

                try

                {

                    con.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                }

                catch (Exception ex)

                {

                    {

                        MessageBox.Show("Erro: " + ex.Message);

                    }

                }

            }

        }
    }
}
