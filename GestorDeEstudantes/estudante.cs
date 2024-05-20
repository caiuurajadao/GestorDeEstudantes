using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantes
{
    internal class estudante
    {
        Meu_Banco_De_Dados meu_Banco_De_Dados = new Meu_Banco_De_Dados();

        public bool inserirEstudante(String nome, string sobrenome, DateTime nascimento,
            string telefone, string genero, string endereco, MemoryStream foto)

        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`id`, `nome`," +
                "`sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES" +
                " (@nome,@sobrenome,@nascimento,@genero,@telefone,@endereco,@foto)", meu_Banco_De_Dados.getConexao);

            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.VarChar).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto;

            meu_Banco_De_Dados.abrirConexão();

            if(comando.ExecuteNonQuery() == 1)
            {
                meu_Banco_De_Dados.fecharConexao();
                return true;

            }
            else
            {
                meu_Banco_De_Dados.fecharConexao();
                return false;
            }
        }
    }
}
