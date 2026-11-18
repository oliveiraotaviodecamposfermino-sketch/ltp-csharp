using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Projeto_Final
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; User Id=root; password=963852741; database=banco_arkiver");
        public string mensagem;

        public bool verifica(string user, string pass)
        {
            string senhaHash = BibliotecaHash.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("sp_ConsultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("loginUser", user);
            cmd.Parameters.AddWithValue("loginPass", senhaHash);
            try
            {
                conexao.Open();//abrindo conexão
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();//tabela virtual
                da.Fill(ds); //passando os valores consultados para o dataset
                if (ds.Tables[0].Rows.Count > 0) // verifica se retornou algum registro
                    return true;
                else
                    return false;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }//fim verifica

    }
}
