using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVerkoop
{
    public partial class frmCadJogo : Form
    {
        private void LimparForm()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            nudPreco.Value = 0;
            nudRestricao.Value = 1;
        }
        public frmCadJogo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || nudPreco.Value == 0 || nudRestricao.Value == 0)
                {
                    MessageBox.Show("Você deve preencher os campos", "Cadastro de jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<object> param = new List<object>();
                param.Add(txtNome.Text);
                param.Add(txtDescricao.Text);
                param.Add(nudPreco.Value);
                param.Add(nudRestricao.Value);

                sql = "INSERT INTO jogo (cod_jogo, nome_jogo, descricao, preco_jogo, restricao) "
                                              + " values (DEFAULT, @1, @2, @3, @4)";


                ConexaoBanco.executar(sql, param);

                MessageBox.Show("Jogo cadastrado com sucesso!",
                      "Cadastro de jogos",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);


                DialogResult result = new DialogResult();
                result = MessageBox.Show("Você deseja cadastar um novo jogo?",
                    "Cadastro de Jogos",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LimparForm();
                    txtNome.Focus();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o jogo" +
                    "\n\nMais detalhes: " + ex.Message, "Cadastro do jogo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}
