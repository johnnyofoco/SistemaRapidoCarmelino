
namespace SistemaRapidoCarmelino.Forms
{
    partial class FormPesquisarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.textBoxNomeFunc = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBoxNumCPF = new System.Windows.Forms.TextBox();
            this.lblNumCPF = new System.Windows.Forms.Label();
            this.textBoxNumPIS = new System.Windows.Forms.TextBox();
            this.lblNumPIS = new System.Windows.Forms.Label();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultadoPesquisaFunc = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltros.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoPesquisaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeFunc.Location = new System.Drawing.Point(6, 29);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(124, 15);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome do funcionário:";
            // 
            // textBoxNomeFunc
            // 
            this.textBoxNomeFunc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomeFunc.Location = new System.Drawing.Point(136, 26);
            this.textBoxNomeFunc.Name = "textBoxNomeFunc";
            this.textBoxNomeFunc.Size = new System.Drawing.Size(499, 23);
            this.textBoxNomeFunc.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(341, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(144, 50);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textBoxNumCPF
            // 
            this.textBoxNumCPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumCPF.Location = new System.Drawing.Point(136, 55);
            this.textBoxNumCPF.Name = "textBoxNumCPF";
            this.textBoxNumCPF.Size = new System.Drawing.Size(154, 23);
            this.textBoxNumCPF.TabIndex = 2;
            // 
            // lblNumCPF
            // 
            this.lblNumCPF.AutoSize = true;
            this.lblNumCPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumCPF.Location = new System.Drawing.Point(65, 58);
            this.lblNumCPF.Name = "lblNumCPF";
            this.lblNumCPF.Size = new System.Drawing.Size(65, 15);
            this.lblNumCPF.TabIndex = 3;
            this.lblNumCPF.Text = "Nº do CPF:";
            // 
            // textBoxNumPIS
            // 
            this.textBoxNumPIS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumPIS.Location = new System.Drawing.Point(136, 83);
            this.textBoxNumPIS.Name = "textBoxNumPIS";
            this.textBoxNumPIS.Size = new System.Drawing.Size(154, 23);
            this.textBoxNumPIS.TabIndex = 4;
            // 
            // lblNumPIS
            // 
            this.lblNumPIS.AutoSize = true;
            this.lblNumPIS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumPIS.Location = new System.Drawing.Point(65, 86);
            this.lblNumPIS.Name = "lblNumPIS";
            this.lblNumPIS.Size = new System.Drawing.Size(60, 15);
            this.lblNumPIS.TabIndex = 5;
            this.lblNumPIS.Text = "Nº do PIS:";
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.btnLimpar);
            this.groupBoxFiltros.Controls.Add(this.textBoxNomeFunc);
            this.groupBoxFiltros.Controls.Add(this.textBoxNumPIS);
            this.groupBoxFiltros.Controls.Add(this.lblNomeFunc);
            this.groupBoxFiltros.Controls.Add(this.lblNumPIS);
            this.groupBoxFiltros.Controls.Add(this.btnPesquisar);
            this.groupBoxFiltros.Controls.Add(this.textBoxNumCPF);
            this.groupBoxFiltros.Controls.Add(this.lblNumCPF);
            this.groupBoxFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFiltros.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(884, 133);
            this.groupBoxFiltros.TabIndex = 7;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros para a pesquisa";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(491, 56);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.dgvResultadoPesquisaFunc);
            this.groupBoxResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxResultado.Location = new System.Drawing.Point(0, 133);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(884, 428);
            this.groupBoxResultado.TabIndex = 8;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado da pesquisa";
            // 
            // dgvResultadoPesquisaFunc
            // 
            this.dgvResultadoPesquisaFunc.AllowUserToAddRows = false;
            this.dgvResultadoPesquisaFunc.AllowUserToDeleteRows = false;
            this.dgvResultadoPesquisaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoPesquisaFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultadoPesquisaFunc.Location = new System.Drawing.Point(3, 19);
            this.dgvResultadoPesquisaFunc.Name = "dgvResultadoPesquisaFunc";
            this.dgvResultadoPesquisaFunc.ReadOnly = true;
            this.dgvResultadoPesquisaFunc.RowTemplate.Height = 25;
            this.dgvResultadoPesquisaFunc.Size = new System.Drawing.Size(878, 406);
            this.dgvResultadoPesquisaFunc.TabIndex = 0;
            // 
            // FormPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.groupBoxFiltros);
            this.Name = "FormPesquisarFuncionario";
            this.Text = "Pesquisar Funcionario";
            this.Load += new System.EventHandler(this.FormPesquisarFuncionario_Load);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoPesquisaFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.TextBox textBoxNomeFunc;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBoxNumCPF;
        private System.Windows.Forms.Label lblNumCPF;
        private System.Windows.Forms.TextBox textBoxNumPIS;
        private System.Windows.Forms.Label lblNumPIS;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dgvResultadoPesquisaFunc;
        private System.Windows.Forms.Button btnLimpar;
    }
}