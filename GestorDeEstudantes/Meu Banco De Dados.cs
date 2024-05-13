using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestorDeEstudantes
{
    internal class Meu_Banco_De_Dados
    {
        //A conexão com o banco de dados
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;root;password=;databse=sga_estudantes_bd_t7");

        // Acessor da variavel "conexão"
        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }

        //Função para ABRIR a conexão com o banco de dados
        public void abrirConexão()
        { 
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        //Função para FECHAR a conexão com o banco de dados
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

    }
}
