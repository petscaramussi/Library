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

    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void bntRegistrar_Click(object sender, EventArgs e)
        {
            Singup sp = new Singup();
            this.Hide();
            sp.Show();
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

            
            
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
