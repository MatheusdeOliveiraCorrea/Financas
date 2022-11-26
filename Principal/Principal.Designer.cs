namespace Principal
{
    partial class Principal
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdAtivos = new System.Windows.Forms.DataGridView();
            this.fundosInvestimentoImobiliarioFIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.telaPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.painelBotoesLaterais = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnVisualizacao = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundosInvestimentoImobiliarioFIIBindingSource)).BeginInit();
            this.telaPrincipal.SuspendLayout();
            this.painelBotoesLaterais.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ativosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ativosToolStripMenuItem
            // 
            this.ativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem});
            this.ativosToolStripMenuItem.Name = "ativosToolStripMenuItem";
            this.ativosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ativosToolStripMenuItem.Text = "Ativos";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // grdAtivos
            // 
            this.grdAtivos.AllowUserToResizeRows = false;
            this.grdAtivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAtivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.grdAtivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAtivos.ColumnHeadersVisible = false;
            this.grdAtivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdAtivos.Location = new System.Drawing.Point(19, 39);
            this.grdAtivos.MultiSelect = false;
            this.grdAtivos.Name = "grdAtivos";
            this.grdAtivos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.grdAtivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAtivos.Size = new System.Drawing.Size(785, 170);
            this.grdAtivos.TabIndex = 3;
            this.grdAtivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAtivos_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(687, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // telaPrincipal
            // 
            this.telaPrincipal.Controls.Add(this.grdAtivos);
            this.telaPrincipal.Controls.Add(this.comboBox1);
            this.telaPrincipal.Location = new System.Drawing.Point(269, 62);
            this.telaPrincipal.Name = "telaPrincipal";
            this.telaPrincipal.Size = new System.Drawing.Size(877, 563);
            this.telaPrincipal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(966, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bem-Vindo Matheus! ";
            // 
            // painelBotoesLaterais
            // 
            this.painelBotoesLaterais.BackColor = System.Drawing.Color.Black;
            this.painelBotoesLaterais.Controls.Add(this.panel2);
            this.painelBotoesLaterais.Controls.Add(this.panel3);
            this.painelBotoesLaterais.Controls.Add(this.panel4);
            this.painelBotoesLaterais.Controls.Add(this.panel5);
            this.painelBotoesLaterais.Controls.Add(this.panel6);
            this.painelBotoesLaterais.Controls.Add(this.panel7);
            this.painelBotoesLaterais.Location = new System.Drawing.Point(0, 27);
            this.painelBotoesLaterais.MaximumSize = new System.Drawing.Size(263, 598);
            this.painelBotoesLaterais.MinimumSize = new System.Drawing.Size(58, 605);
            this.painelBotoesLaterais.Name = "painelBotoesLaterais";
            this.painelBotoesLaterais.Size = new System.Drawing.Size(263, 605);
            this.painelBotoesLaterais.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 44);
            this.panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-6, -3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(280, 61);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTelaInicial);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 57);
            this.panel3.TabIndex = 1;
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaInicial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnTelaInicial.Image")));
            this.btnTelaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaInicial.Location = new System.Drawing.Point(-15, -12);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTelaInicial.Size = new System.Drawing.Size(280, 77);
            this.btnTelaInicial.TabIndex = 0;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCalculadora);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(3, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 57);
            this.panel4.TabIndex = 2;
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(-15, -12);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCalculadora.Size = new System.Drawing.Size(280, 77);
            this.btnCalculadora.TabIndex = 0;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnConfiguracoes);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(3, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 57);
            this.panel5.TabIndex = 3;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.Image")));
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(-15, -12);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(280, 77);
            this.btnConfiguracoes.TabIndex = 0;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnUsuario);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(3, 242);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 57);
            this.panel6.TabIndex = 4;
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(-15, -12);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(280, 77);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuario ";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnVisualizacao);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(3, 305);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(277, 57);
            this.panel7.TabIndex = 5;
            // 
            // btnVisualizacao
            // 
            this.btnVisualizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizacao.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVisualizacao.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizacao.Image")));
            this.btnVisualizacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizacao.Location = new System.Drawing.Point(-15, -12);
            this.btnVisualizacao.Name = "btnVisualizacao";
            this.btnVisualizacao.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVisualizacao.Size = new System.Drawing.Size(280, 77);
            this.btnVisualizacao.TabIndex = 0;
            this.btnVisualizacao.Text = "Visualização";
            this.btnVisualizacao.UseVisualStyleBackColor = true;
            this.btnVisualizacao.MouseEnter += new System.EventHandler(this.VisualizacaoMouseEnter);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.painelBotoesLaterais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telaPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Financas";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundosInvestimentoImobiliarioFIIBindingSource)).EndInit();
            this.telaPrincipal.ResumeLayout(false);
            this.painelBotoesLaterais.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdAtivos;
        private System.Windows.Forms.BindingSource fundosInvestimentoImobiliarioFIIBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel telaPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel painelBotoesLaterais;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTelaInicial;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnVisualizacao;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button btnMenu;
    }
}

