using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCSharp
{
    
    class Conexao
    {

        MySqlConnection con = new MySqlConnection();
    
        public Conexao() {
            con.ConnectionString = "server=localhost;port=3306;User Id=root;database=biblio;password=";
        }

        public MySqlConnection Conectar() {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void Cadastro(String nome, String senha, String rg, String cpf, String email, String telefone)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO usuario VALUES(?nome,?senha,?rg,?cpf,?email,?telefone)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("?senha", MySqlDbType.VarChar).Value = senha;
                cmd.Parameters.Add("?rg", MySqlDbType.VarChar).Value = rg;
                cmd.Parameters.Add("?cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("?telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso");

            }catch(Exception )
            {
                MessageBox.Show("erro ao cadastrar");
            }
        }

    }
}
