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
    public partial class frmPesqJogo : Form
    {
        private void LimparForm()
        {
            cboNome.Checked = false;
            cboPreco.Checked = false;
            cboRestricao.Checked = false;  
            
            txtNome.Enabled = false;
            nudPreco.Enabled = false;
            nudRestricao.Enabled = false;

            txtNome.Text = "";
            nudPreco.Value = 0;
            nudRestricao.Value = 1;
        }
        public frmPesqJogo()
        {
            InitializeComponent();
        }
        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (cboNome.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtNome.Text))
                    {
                        MessageBox.Show("Você deve preencher os campos", "Pesquisa de jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                List<object> param = new List<object>();
                param.Add(txtNome.Text);
                param.Add(nudPreco.Value);
                param.Add(nudRestricao.Value);     

                if (cboNome.Checked == true && cboRestricao.Checked == false && cboPreco.Checked == false)
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE nome_jogo = " + "'" + txtNome.Text + "'";
                }

                else if (cboNome.Checked == false && cboRestricao.Checked == true && cboPreco.Checked == false)
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE restricao = " + "'" + nudRestricao.Value + "'";
                }

                else if (cboNome.Checked == false && cboRestricao.Checked == false && cboPreco.Checked == true)
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE preco_jogo = " + nudPreco.Value;
                }

                else if (cboNome.Checked == true && cboRestricao.Checked == true && cboPreco.Checked == false)
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE nome_jogo = " + "'" + txtNome.Text + "' AND restricao = '" + nudRestricao.Value + "'";
                }

                else if (cboNome.Checked == true && cboRestricao.Checked == false && cboPreco.Checked == true)
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE preco_jogo = " + nudPreco.Value + " AND nome_jogo = '" + txtNome.Text + "'";
                }

                else if (cboNome.Checked == false && cboRestricao.Checked == true && cboPreco.Checked == true)
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE preco_jogo = " + nudPreco.Value + " AND restricao = '" + nudRestricao.Value + "'";
                }

                else if (cboNome.Checked == false && cboRestricao.Checked == true && cboPreco.Checked == true)
                { 
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE preco_jogo = " + nudPreco.Value + " AND restricao = '" + nudRestricao.Value + "'";
                }

                else if (cboNome.Checked == true && cboRestricao.Checked == true && cboPreco.Checked == true)
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo" + " WHERE preco_jogo = " + nudPreco.Value + " AND restricao = '" + nudRestricao.Value + "'" 
                        + " AND nome_jogo = '" + txtNome.Text + "'";
                }

                else
                {
                    sql = "SELECT nome_jogo, preco_jogo, descricao, restricao FROM jogo";
                }

                ConexaoBanco.executar(sql, param);
                lblRestricao.DataSource = ConexaoBanco.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os jogos!!!" + "\n\nMais detalhes: "
                + ex.Message, "Pesquisa de jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecFiltros_Click(object sender, EventArgs e)
        {
            if (cboNome.Checked)
            {
                txtNome.Enabled = true;
            }
            else
            {
                txtNome.Enabled = false;
            }
            if (cboPreco.Checked)
            {
                nudPreco.Enabled = true;
            }
            else
            {
                nudPreco.Enabled = false;
            }
            if (cboRestricao.Checked)
            {
                nudRestricao.Enabled = true;
            }
            else
            {
                nudRestricao.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Você deseja pesquisar um jogo?",
                "Pesquisa de Jogos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LimparForm();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }

            
        }
    }
}
