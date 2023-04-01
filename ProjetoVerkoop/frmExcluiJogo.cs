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
    public partial class frmExcluiJogo : Form
    {
        private void LimparForm()
        {
            txtCodJogo.Clear();
        }
        public frmExcluiJogo()
        {
            InitializeComponent();
            pesquisa();
        }

        private void pesquisa()
        {
            string sql;
            try
            {
                List<object> param = new List<object>();

                sql = "SELECT cod_jogo as codigo, nome_jogo as nome FROM jogo order by cod_jogo";

                ConexaoBanco.executar(sql);
                lblRestricao.DataSource = ConexaoBanco.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os jogos!" + "\n\nMais detalhes: "
                + ex.Message, "Exclusão de jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCodJogo.Text))
            {
                MessageBox.Show("Você deve digitar o código do jogo a ser excluído!","Exclusão de jogos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCodJogo.Focus();
                return;
            }
           
            string sql;
            try
            {
                sql = "SELECT COUNT(*) from jogo WHERE cod_jogo = " + txtCodJogo.Text;

                int rows = ConexaoBanco.executar2(sql);

                if(rows==0)
                {
                    MessageBox.Show("O código digitado não existe!", "Exclusão de jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodJogo.Text = "";
                    txtCodJogo.Focus();
                    return;
                }

                DialogResult cancel = MessageBox.Show("Tem certeza que deseja excluir?\nEssa ação não poderá ser revertida!", "Exlusão de jogos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (cancel == DialogResult.Cancel)
                {
                    txtCodJogo.Text = "";
                    return;
                }
                sql = "DELETE FROM jogo WHERE cod_jogo = " + txtCodJogo.Text;

                ConexaoBanco.executar(sql);

                MessageBox.Show("Jogo excluído com sucesso!", "Exclusão de jogos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult result = new DialogResult();
                result = MessageBox.Show("Você deseja excluir um jogo?",
                    "Exclusão de Jogos",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LimparForm();
                    txtCodJogo.Focus();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o jogo!" + "\n\nMais detalhes: "
                + ex.Message, "Exclusão de jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pesquisa();
        }

        private void txtCodJogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }
    }
}
