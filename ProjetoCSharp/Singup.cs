using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCSharp
{
    
    public partial class Singup : Form
    {
       
        public Singup()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //tratamento de erros



            //instancia da classe do banco
            Conexao conexao = new Conexao();

            
            conexao.Conectar();
            

            //inserção no banco de dados
            conexao.Cadastro(txtNome.Text,txtSenha.Text,txtRg.Text,txtCPF.Text,txtEmail.Text,txtTelefone.Text);

            
            conexao.Desconectar();



        }

        private void txtNome_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRg_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
