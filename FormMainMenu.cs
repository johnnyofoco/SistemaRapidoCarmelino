using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRapidoCarmelino
{
    public partial class FormMainMenu : Form
    {

        //Campos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        //Métodos
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index){
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
               if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    label2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        //Acessar_Outros_Forms
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        //Click_Events
        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPesquisarFuncionario(), sender);
        }

        private void btnConferirVerbas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            MessageBox.Show(this, "A tela para Conferir Verbas está em desenvolvimento.",
                                   "Aviso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
        }

        private void btnRelatorioCustos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            MessageBox.Show(this, "A tela do Relatório de Custos está em desenvolvimento.",
                       "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            MessageBox.Show(this, "A tela das Configurações... enfim você já sabe!",
                       "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }
    }
}
