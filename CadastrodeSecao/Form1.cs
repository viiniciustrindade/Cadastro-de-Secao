using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrodeSecao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadId()
        {
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtBibSecao') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());


                txtCodSecao.Text = proximoID.ToString();
            }
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SecaoDao dao = new SecaoDao(connection);
                List<SecaoModel> secoes = dao.GetEditoras();
                foreach (SecaoModel secao in secoes)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodSecao.Index].Value = secao.codSecao;
                    row.Cells[colDescSecao.Index].Value = secao.descSecao;

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            LoadId();
            btn_Excluir.Enabled = false;
        }       
         private void btn_Salvar_Click_1(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtDescSecao.Text) || string.IsNullOrWhiteSpace(txtDescSecao.Text))
            {
                MessageBox.Show("Informe o campo [Descrição]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    SecaoDao dao = new SecaoDao(connection);

                    string sql2 = "SELECT COUNT(codSecao) FROM mvtBibSecao WHERE codSecao = @secao";
                    SqlCommand cmdSelect = new SqlCommand(sql2, connection);
                    cmdSelect.Parameters.AddWithValue("@secao", txtCodSecao.Text);
                    int count = Convert.ToInt32(cmdSelect.ExecuteScalar());

                    if (count > 0)
                    {
                        dao.Alterar(new SecaoModel()
                        {
                            codSecao = txtCodSecao.Text,
                            descSecao = txtDescSecao.Text,
                        });
                    }
                    else
                    {
                        dao.Salvar(new SecaoModel()
                        {
                            descSecao = txtDescSecao.Text,
                        });
                    }


                    MessageBox.Show("Seção salva com sucesso!");
                    // se salvar deu certo carrega os usuários
                    CarregarUsuariosGrid();
                    LoadId();
                    btn_Excluir.Enabled = false;
                    txtDescSecao.Text = "";
                }
            }
            catch (Exception ex)
            {
                // se salvar deu errado mostra mensagem
                MessageBox.Show($"Houve um problema ao salvar o usuário!\n{ex.Message}");
            }
        }
        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodSecao.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodSecao.Index].Value + "";
                txtDescSecao.Text = dadosGrid.Rows[e.RowIndex].Cells[colDescSecao.Index].Value + "";
                if (string.IsNullOrEmpty(this.txtDescSecao.Text))
                {
                    btn_Excluir.Enabled = false;

                }
                else
                {
                    btn_Excluir.Enabled = true;
                }
            }
        }

        private void btn_Excluir_Click_1(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtDescSecao.Text) || string.IsNullOrWhiteSpace(txtDescSecao.Text))
            {
                MessageBox.Show("Seção não foi selecionada!", "Atenção");
                return;
            }
            DialogResult confirmacao = MessageBox.Show("Deseja Excluir a Seção?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (confirmacao == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        SecaoDao dao = new SecaoDao(connection);
                        dao.Excluir(new SecaoModel()
                        {
                            codSecao = txtCodSecao.Text
                        });
                    }
                    MessageBox.Show("Seção excluída com sucesso!");
                    CarregarUsuariosGrid();
                    LoadId();
                    btn_Excluir.Enabled = false;
                    txtDescSecao.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir a editora!\n{ex.Message}");
            }
        }
    }
}

