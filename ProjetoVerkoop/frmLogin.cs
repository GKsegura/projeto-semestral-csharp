using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProjetoVerkoop
{
    public partial class frmLogin : Form
    {
        Form parent;
        public frmLogin(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\u0000')
            {
                txtSenha.PasswordChar = '*';
            }
            else
            {
                txtSenha.PasswordChar = '\u0000';
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                sql = "select * from usuario ";
                sql += "where username = @1";

                List<object> list = new List<object>();
                list.Add(txtUsername.Text);

                NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, list);
                if (dr.Read())
                {
                    if (MD5.compareHash(txtSenha.Text, dr["senha"].ToString()))
                    {
                        MessageBox.Show("Olá, " + dr["nome_usuario"].ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dr.Close();
                        VariavelGlobal.logado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Username não cadastrado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao logar!" + "\n\nMais detalhes: " + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadUsuario CadUsu = new frmCadUsuario();
            CadUsu.ShowDialog();
        }
    }
}
