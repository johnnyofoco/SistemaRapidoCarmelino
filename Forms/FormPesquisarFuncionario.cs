using SistemaRapidoCarmelino.BD;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaRapidoCarmelino.Forms
{
    public partial class FormPesquisarFuncionario : Form
    {
        public FormPesquisarFuncionario()
        {
            InitializeComponent();
        }

        DAL acesso = new DAL();

        //Metódos
        private void FormPesquisarFuncionario_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in groupBoxFiltros.Controls) //this.Controls
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }

        //Pesquisa com Filtro
        private void atualizarExibicaoComFiltro()
        {

            //Se todos os campos estiverem vazios
            if (textBoxNomeFunc.Text.ToString() == "" && 
                 textBoxNumCPF.Text.ToString() == "" && 
                  textBoxNumPIS.Text.ToString() == "")
            {
                MessageBox.Show("Preencha pelo menos um dos filtros disponíveis!");
            }
            else
            {
                dgvResultadoPesquisaFunc.DataSource = acesso.GetRegistroComFiltro(
                                    textBoxNomeFunc.Text.ToString(),
                                    textBoxNumCPF.Text.ToString(),
                                    textBoxNumPIS.Text.ToString());
            }
        }

        //Click_Event
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                atualizarExibicaoComFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxNomeFunc.Text = "";
            textBoxNumCPF.Text = "";
            textBoxNumPIS.Text = "";
            dgvResultadoPesquisaFunc.DataSource = "";
        }
    }
}
