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

namespace GestorDeEstudantes
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Meu_Banco_De_Dados meu_Banco_De_Dados = new Meu_Banco_De_Dados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter ();
            DataTable tabeDeDados = new DataTable();
            MySqlCommand comandoSql = new MySqlCommand("", meu_Banco_De_Dados.getConexao);

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
