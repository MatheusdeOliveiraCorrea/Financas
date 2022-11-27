using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Principal
{
    public partial class Configuracoes : Form
    {
        private readonly Color botao_cor_padrao;

        private readonly List<Button> botoesDoMenu; 

        public Configuracoes()
        {
            InitializeComponent();
            botoesDoMenu = new List<Button>();
            botao_cor_padrao = Color.FromArgb(100, Color.LightCyan);

            DefinirBotoesMenu();
            SelecionarBotao(this.button1);
        }

        private void SelecionarBotao(Button botao)
        {
            PorCorPadrao(botao); 
        }

        private void PorCorPadrao(Button botao)
        {
            botao.BackColor = botao_cor_padrao; 
        }

        private void MudarCorFundoBotao(List<Button> botoes)
        {
            foreach (var botao in botoes)
                SelecionarBotao(botao);
        }

        private void MudarCorFundoBotao(Color cor, params Button[] botoes)
        {
            foreach (var botao in botoes)
                botao.BackColor = cor; 
        }

        private void MudarCorFundoBotao(params Button[] botoes)
        {
            foreach (var botao in botoes)
                SelecionarBotao(botao);
        }

        private void DefinirBotoesMenu()
        {
            botoesDoMenu.Add(this.button1);
            botoesDoMenu.Add(this.button2);
            botoesDoMenu.Add(this.button3);
            botoesDoMenu.Add(this.button4);
        }

        private void AoPassarMouse(object sender, System.EventArgs e)
        {
            MudarCorFundoBotao(botoesDoMenu);
        }
    }
}
