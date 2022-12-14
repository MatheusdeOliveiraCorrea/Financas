using Nucleo.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ServicosExternos.Fabrica.API;
using System.Drawing.Text;

namespace Principal
{

    public partial class Principal : Form
    {

        private List<FundosInvestimentoImobiliarioFII> ListaFII = new List<FundosInvestimentoImobiliarioFII>() { new FundosInvestimentoImobiliarioFII() { Codigo = "TESTE11", Preco = 113.95 }, new FundosInvestimentoImobiliarioFII() { Codigo = "segundo11" } };

        public Principal()
        {
            InitializeComponent();
            FII("rztr11");
            PreencherGrid();
            AjustarOrdemColunas();
            AjustarControles();
        }

        private void AjustarControles()
        {
            NaoSelecionarNadaAoInicializar();
            FormatarColunas();
            FormatarLinhas();
            FormatarElementos();
            
        }

        private void FormatarElementos()
        {
            comboBox1.Items.AddRange(new string[] { "FII", "Acões", "Tudo" });
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void NaoSelecionarNadaAoInicializar()
        {
            this.grdAtivos.DefaultCellStyle.SelectionBackColor = this.grdAtivos.RowsDefaultCellStyle.BackColor;
            this.grdAtivos.DefaultCellStyle.SelectionForeColor = this.grdAtivos.DefaultCellStyle.ForeColor;
        }

        private void FormatarColunas()
        {
            grdAtivos.Columns["Preco"].DefaultCellStyle.Format = "c";
            grdAtivos.Columns["Preco"].DefaultCellStyle.ForeColor = System.Drawing.Color.Green;

            grdAtivos.AllowUserToResizeColumns = false;
        }

        private void FormatarLinhas()
        {
            grdAtivos.RowTemplate.Height = 50;
        }

        private void AjustarOrdemColunas()
        {
            try
            {
                grdAtivos.Columns["Nome"].Visible = false;
                grdAtivos.Columns["Tipo"].Visible = false;
                grdAtivos.Columns["NomeEmpresa"].Visible = false;
                grdAtivos.Columns["Codigo"].DisplayIndex = 0;
                grdAtivos.Columns["Preco"].DisplayIndex = 1;
            }
            catch (Exception)
            {
            }
        }

        private void PreencherGrid()
        {
            grdAtivos.DataSource = null;
            grdAtivos.DataSource = ListaFII;
        }

        private void FII(string codigoFII)
        {
            try
            {
                var construtor = new ConstrutorAPI();

                var fii = construtor.CriarAPI();

                ListaFII.Add(fii.BuscarFII(codigoFII));
            }
            catch (Exception)
            {
            }
        }

        bool sidebarexpand; 
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 25; 
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebarTimer.Stop(); 
                }
            }
            else
            {
                sidebar.Width += 25;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void grdAtivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void VisualizacaoMouseEnter(object sender, EventArgs e)
        {
            DefinirCorBotao(btnVisualizacao, Color.Azure); 
        }

        private void DefinirCorBotao(Button btn, Color cor)
        {
            btnVisualizacao.ForeColor = Color.Azure;
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            new Configuracoes().Show();
        }
    }
}
