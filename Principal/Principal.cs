using NucleoRegras.Models;
using ServicosExternos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

            //var Form1 = new Form1();
            //Form1.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is MdiClient)
                {
                    controle.BackColor = Color.FromArgb((int)(byte)22, (int)(byte)24, (int)(byte)26);
                    break;
                }
            }

            //this.telaPrincipal.BackColor = Color.FromArgb((int)(byte)22, (int)(byte)24, (int)(byte)26);
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
            grdAtivos.Columns["Preco"].DefaultCellStyle.ForeColor = Color.Green;

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
                var financeApi = new ServicosAPI();
                var fii = financeApi.BuscarFII(codigoFII);
                ListaFII.Add(fii);
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
                painelBotoesLaterais.Width -= 25; 
                if(painelBotoesLaterais.Width == painelBotoesLaterais.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebarTimer.Stop(); 
                }
            }
            else
            {
                painelBotoesLaterais.Width += 25;
                if(painelBotoesLaterais.Width == painelBotoesLaterais.MaximumSize.Width)
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
            //var ad = new Form1();
            //ad.ShowDialog();
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
            new MDIParent1().Show();
        }


    }
}
