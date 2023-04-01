using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVerkoop
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            string sql;
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtSobrenome.Text) || string.IsNullOrEmpty(dtpDataNasc.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtConfirmaSenha.Text))
                {
                    MessageBox.Show("Você deve preencher os campos", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(txtSenha.Text != txtConfirmaSenha.Text)
                {
                    MessageBox.Show("As senhas não coicidem!","Cadastro de usuário", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtConfirmaSenha.Clear();
                    txtConfirmaSenha.Focus();
                    return;
                }

                string senhaCrip = MD5.returnHash(txtSenha.Text);

                string nome = txtNome.Text + " " + txtSobrenome.Text;

                List<object> param = new List<object>();
                param.Add(nome);
                param.Add(txtUsername.Text);
                param.Add(txtEmail.Text);
                param.Add(senhaCrip);
                param.Add(Convert.ToDateTime(dtpDataNasc.Value.ToString("yyyy-MM-dd")));

                    sql = "INSERT INTO usuario (nome_usuario, username, email, senha, data_nasc) "
                                               + " values (@1, @2, @3, @4, @5)";
                
                ConexaoBanco.executar(sql, param);

                    MessageBox.Show("Usuário cadastrado com sucesso!",
                       "Cadastro de usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
               
               this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados do usuário" +
                    "\n\nMais detalhes: " + ex.Message, "Cadastro do usuário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
