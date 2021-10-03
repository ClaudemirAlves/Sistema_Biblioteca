
namespace Sistema_Biblioteca_Publica_HoW_III
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewLeitor = new System.Windows.Forms.DataGridView();
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelWhatsApp = new System.Windows.Forms.Label();
            this.labelCadastroLeitor = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelFormaEnvio = new System.Windows.Forms.Label();
            this.comboBoxEnvio = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWhatsApp = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCEP = new System.Windows.Forms.Label();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAlterarLimite = new System.Windows.Forms.Button();
            this.buttonPendencias = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelCadastroLivro = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAno = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.buttonCadastrarObra = new System.Windows.Forms.Button();
            this.buttonBuscarObra = new System.Windows.Forms.Button();
            this.buttonLimparObra = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.labelLivrosEmprestados = new System.Windows.Forms.Label();
            this.buttonEditarObra = new System.Windows.Forms.Button();
            this.buttonDevolveObra = new System.Windows.Forms.Button();
            this.buttonRenovarObra = new System.Windows.Forms.Button();
            this.buttonReservarObra = new System.Windows.Forms.Button();
            this.buttonEmprestarObra = new System.Windows.Forms.Button();
            this.labelLeitoresCadastrados = new System.Windows.Forms.Label();
            this.labelLivrosCadastrados = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxIdLeitor = new System.Windows.Forms.TextBox();
            this.buttonInativaLeitor = new System.Windows.Forms.Button();
            this.buttonObrasInativas = new System.Windows.Forms.Button();
            this.buttonLeitorInativo = new System.Windows.Forms.Button();
            this.buttonReativarObra = new System.Windows.Forms.Button();
            this.buttonReativarLeitor = new System.Windows.Forms.Button();
            this.ColumnIdE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTituloE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutorE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTituloL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutorL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWhatsapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLimiteObrasLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLeitor
            // 
            this.dataGridViewLeitor.AccessibleDescription = "";
            this.dataGridViewLeitor.AccessibleName = "";
            this.dataGridViewLeitor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.ColumnCpf,
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnWhatsapp,
            this.ColumnEmail,
            this.ColumnFormaEnvio,
            this.ColumnRua,
            this.ColumnNumero,
            this.ColumnComplemento,
            this.ColumnBairro,
            this.ColumnCidade,
            this.ColumnEstado,
            this.ColumnCep,
            this.ColumnLimiteObrasLeitor,
            this.ColumnAtivo});
            this.dataGridViewLeitor.Location = new System.Drawing.Point(12, 297);
            this.dataGridViewLeitor.Name = "dataGridViewLeitor";
            this.dataGridViewLeitor.Size = new System.Drawing.Size(723, 205);
            this.dataGridViewLeitor.TabIndex = 150;
            this.dataGridViewLeitor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeitor_CellDoubleClick);
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdL,
            this.ColumnTituloL,
            this.ColumnValorL,
            this.ColumnAnoL,
            this.ColumnQuantidadeL,
            this.ColumnAutorL,
            this.ColumnGenero,
            this.ColumnDescricao,
            this.ColumnAtivoL});
            this.dataGridViewLivros.Location = new System.Drawing.Point(756, 353);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.Size = new System.Drawing.Size(591, 340);
            this.dataGridViewLivros.TabIndex = 200;
            this.dataGridViewLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLivros_CellDoubleClick);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(14, 157);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 16);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-mail";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(13, 39);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(34, 16);
            this.labelCPF.TabIndex = 3;
            this.labelCPF.Text = "CPF";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(165, 35);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 16);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRua.Location = new System.Drawing.Point(13, 65);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(33, 16);
            this.labelRua.TabIndex = 5;
            this.labelRua.Text = "Rua";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(133, 128);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(63, 16);
            this.labelTelefone.TabIndex = 6;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelWhatsApp
            // 
            this.labelWhatsApp.AutoSize = true;
            this.labelWhatsApp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhatsApp.Location = new System.Drawing.Point(321, 131);
            this.labelWhatsApp.Name = "labelWhatsApp";
            this.labelWhatsApp.Size = new System.Drawing.Size(72, 16);
            this.labelWhatsApp.TabIndex = 7;
            this.labelWhatsApp.Text = "WhatsApp";
            // 
            // labelCadastroLeitor
            // 
            this.labelCadastroLeitor.AutoSize = true;
            this.labelCadastroLeitor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroLeitor.Location = new System.Drawing.Point(13, 9);
            this.labelCadastroLeitor.Name = "labelCadastroLeitor";
            this.labelCadastroLeitor.Size = new System.Drawing.Size(150, 19);
            this.labelCadastroLeitor.TabIndex = 8;
            this.labelCadastroLeitor.Text = "Cadastro de Leitor";
            // 
            // textBoxNome
            // 
            this.textBoxNome.AccessibleDescription = "Nome Completo";
            this.textBoxNome.AccessibleName = "Nome Completo";
            this.textBoxNome.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.textBoxNome.Location = new System.Drawing.Point(216, 35);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(325, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // labelFormaEnvio
            // 
            this.labelFormaEnvio.AutoSize = true;
            this.labelFormaEnvio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaEnvio.Location = new System.Drawing.Point(328, 158);
            this.labelFormaEnvio.Name = "labelFormaEnvio";
            this.labelFormaEnvio.Size = new System.Drawing.Size(122, 16);
            this.labelFormaEnvio.TabIndex = 15;
            this.labelFormaEnvio.Text = "Forma de Contato";
            // 
            // comboBoxEnvio
            // 
            this.comboBoxEnvio.FormattingEnabled = true;
            this.comboBoxEnvio.Items.AddRange(new object[] {
            "",
            "Telefone",
            "WhatsApp",
            "E-mail"});
            this.comboBoxEnvio.Location = new System.Drawing.Point(454, 157);
            this.comboBoxEnvio.Name = "comboBoxEnvio";
            this.comboBoxEnvio.Size = new System.Drawing.Size(86, 21);
            this.comboBoxEnvio.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(548, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 206);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(53, 35);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxCPF.TabIndex = 1;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(202, 127);
            this.maskedTextBoxTelefone.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBoxTelefone.TabIndex = 10;
            // 
            // maskedTextBoxWhatsApp
            // 
            this.maskedTextBoxWhatsApp.Location = new System.Drawing.Point(399, 129);
            this.maskedTextBoxWhatsApp.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxWhatsApp.Name = "maskedTextBoxWhatsApp";
            this.maskedTextBoxWhatsApp.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBoxWhatsApp.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(68, 156);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(236, 20);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(53, 64);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(181, 20);
            this.textBoxRua.TabIndex = 3;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(251, 66);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(22, 16);
            this.labelNumero.TabIndex = 23;
            this.labelNumero.Text = "Nº";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(279, 64);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(56, 20);
            this.textBoxNumero.TabIndex = 4;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplemento.Location = new System.Drawing.Point(359, 66);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(53, 16);
            this.labelComplemento.TabIndex = 25;
            this.labelComplemento.Text = "Compl.";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(418, 64);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(123, 20);
            this.textBoxComplemento.TabIndex = 5;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(15, 97);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(47, 16);
            this.labelBairro.TabIndex = 27;
            this.labelBairro.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(68, 97);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(155, 20);
            this.textBoxBairro.TabIndex = 6;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(242, 97);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(53, 16);
            this.labelCidade.TabIndex = 29;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(301, 97);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(145, 20);
            this.textBoxCidade.TabIndex = 7;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(463, 98);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(25, 16);
            this.labelEstado.TabIndex = 32;
            this.labelEstado.Text = "UF";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.Location = new System.Drawing.Point(14, 128);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(34, 16);
            this.labelCEP.TabIndex = 33;
            this.labelCEP.Text = "CEP";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(54, 124);
            this.maskedTextBoxCEP.Mask = "00000-999";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBoxCEP.TabIndex = 9;
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxEstados.Location = new System.Drawing.Point(494, 95);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(46, 21);
            this.comboBoxEstados.TabIndex = 8;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.AutoEllipsis = true;
            this.buttonCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonCadastrar.Location = new System.Drawing.Point(94, 192);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(83, 40);
            this.buttonCadastrar.TabIndex = 14;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.AutoEllipsis = true;
            this.buttonEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditar.BackColor = System.Drawing.Color.Gold;
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonEditar.Location = new System.Drawing.Point(360, 192);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(82, 40);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = "Editar Perfil";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonAlterarLimite
            // 
            this.buttonAlterarLimite.AutoEllipsis = true;
            this.buttonAlterarLimite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAlterarLimite.BackColor = System.Drawing.Color.Gold;
            this.buttonAlterarLimite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlterarLimite.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonAlterarLimite.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonAlterarLimite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonAlterarLimite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonAlterarLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAlterarLimite.Location = new System.Drawing.Point(282, 251);
            this.buttonAlterarLimite.Name = "buttonAlterarLimite";
            this.buttonAlterarLimite.Size = new System.Drawing.Size(82, 40);
            this.buttonAlterarLimite.TabIndex = 18;
            this.buttonAlterarLimite.Text = "Alterar Limite de Obra";
            this.buttonAlterarLimite.UseVisualStyleBackColor = false;
            // 
            // buttonPendencias
            // 
            this.buttonPendencias.AutoEllipsis = true;
            this.buttonPendencias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPendencias.BackColor = System.Drawing.Color.Gold;
            this.buttonPendencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPendencias.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonPendencias.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonPendencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonPendencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonPendencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonPendencias.Location = new System.Drawing.Point(371, 251);
            this.buttonPendencias.Name = "buttonPendencias";
            this.buttonPendencias.Size = new System.Drawing.Size(82, 40);
            this.buttonPendencias.TabIndex = 19;
            this.buttonPendencias.Text = "Pendências Financeiras";
            this.buttonPendencias.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.AutoEllipsis = true;
            this.buttonBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuscar.BackColor = System.Drawing.Color.Gold;
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBuscar.Location = new System.Drawing.Point(271, 192);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(83, 40);
            this.buttonBuscar.TabIndex = 16;
            this.buttonBuscar.Text = "Buscar Leitor";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // labelCadastroLivro
            // 
            this.labelCadastroLivro.AutoSize = true;
            this.labelCadastroLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroLivro.Location = new System.Drawing.Point(753, 9);
            this.labelCadastroLivro.Name = "labelCadastroLivro";
            this.labelCadastroLivro.Size = new System.Drawing.Size(143, 19);
            this.labelCadastroLivro.TabIndex = 41;
            this.labelCadastroLivro.Text = "Cadastro de Obra";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.AutoEllipsis = true;
            this.buttonLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLimpar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonLimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonLimpar.Location = new System.Drawing.Point(183, 192);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(82, 40);
            this.buttonLimpar.TabIndex = 15;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(754, 39);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(99, 16);
            this.labelTitulo.TabIndex = 43;
            this.labelTitulo.Text = "Título da Obra";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(754, 66);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(124, 16);
            this.labelValor.TabIndex = 44;
            this.labelValor.Text = "Valor da Obra (R$)";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(753, 94);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(97, 16);
            this.labelAutor.TabIndex = 45;
            this.labelAutor.Text = "Autor da Obra";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(946, 66);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(33, 16);
            this.labelAno.TabIndex = 46;
            this.labelAno.Text = "Ano";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(753, 128);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(110, 16);
            this.labelGenero.TabIndex = 47;
            this.labelGenero.Text = "Gênero da Obra";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(753, 162);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(70, 16);
            this.labelDescricao.TabIndex = 48;
            this.labelDescricao.Text = "Descrição";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(859, 38);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(276, 20);
            this.textBoxTitulo.TabIndex = 50;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(856, 93);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(279, 20);
            this.textBoxAutor.TabIndex = 54;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(869, 124);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(266, 20);
            this.textBoxGenero.TabIndex = 55;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1143, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 202);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(884, 64);
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(48, 20);
            this.maskedTextBoxValor.TabIndex = 51;
            // 
            // maskedTextBoxAno
            // 
            this.maskedTextBoxAno.Location = new System.Drawing.Point(985, 64);
            this.maskedTextBoxAno.Name = "maskedTextBoxAno";
            this.maskedTextBoxAno.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxAno.TabIndex = 52;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(829, 157);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(306, 88);
            this.richTextBoxDescricao.TabIndex = 56;
            this.richTextBoxDescricao.Text = "";
            // 
            // buttonCadastrarObra
            // 
            this.buttonCadastrarObra.AutoEllipsis = true;
            this.buttonCadastrarObra.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCadastrarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrarObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonCadastrarObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonCadastrarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonCadastrarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonCadastrarObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonCadastrarObra.Location = new System.Drawing.Point(878, 251);
            this.buttonCadastrarObra.Name = "buttonCadastrarObra";
            this.buttonCadastrarObra.Size = new System.Drawing.Size(82, 40);
            this.buttonCadastrarObra.TabIndex = 60;
            this.buttonCadastrarObra.Text = "Cadastrar Obra";
            this.buttonCadastrarObra.UseVisualStyleBackColor = false;
            this.buttonCadastrarObra.Click += new System.EventHandler(this.buttonCadastrarObra_Click);
            // 
            // buttonBuscarObra
            // 
            this.buttonBuscarObra.AutoEllipsis = true;
            this.buttonBuscarObra.BackColor = System.Drawing.Color.Gold;
            this.buttonBuscarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonBuscarObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonBuscarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonBuscarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonBuscarObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBuscarObra.Location = new System.Drawing.Point(1054, 251);
            this.buttonBuscarObra.Name = "buttonBuscarObra";
            this.buttonBuscarObra.Size = new System.Drawing.Size(82, 40);
            this.buttonBuscarObra.TabIndex = 62;
            this.buttonBuscarObra.Text = "Buscar Obra";
            this.buttonBuscarObra.UseVisualStyleBackColor = false;
            this.buttonBuscarObra.Click += new System.EventHandler(this.buttonBuscarObra_Click);
            // 
            // buttonLimparObra
            // 
            this.buttonLimparObra.AutoEllipsis = true;
            this.buttonLimparObra.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLimparObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimparObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonLimparObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonLimparObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonLimparObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonLimparObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonLimparObra.Location = new System.Drawing.Point(966, 251);
            this.buttonLimparObra.Name = "buttonLimparObra";
            this.buttonLimparObra.Size = new System.Drawing.Size(82, 40);
            this.buttonLimparObra.TabIndex = 61;
            this.buttonLimparObra.Text = "Limpar";
            this.buttonLimparObra.UseVisualStyleBackColor = false;
            this.buttonLimparObra.Click += new System.EventHandler(this.buttonLimparObra_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.AutoEllipsis = true;
            this.buttonExcluir.BackColor = System.Drawing.Color.Red;
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(1090, 307);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(81, 40);
            this.buttonExcluir.TabIndex = 66;
            this.buttonExcluir.Text = "Inativar Obra";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(1049, 66);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(54, 16);
            this.labelQuantidade.TabIndex = 102;
            this.labelQuantidade.Text = "Qtdade";
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(1109, 65);
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBoxQuantidade.TabIndex = 53;
            // 
            // dataGridViewEmprestimo
            // 
            this.dataGridViewEmprestimo.AccessibleDescription = "";
            this.dataGridViewEmprestimo.AccessibleName = "";
            this.dataGridViewEmprestimo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdE,
            this.ColumnTituloE,
            this.ColumnAutorE,
            this.ColumnValorE,
            this.ColumnAnoE,
            this.ColumnDataDevolucao});
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(12, 562);
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(723, 131);
            this.dataGridViewEmprestimo.TabIndex = 170;
            // 
            // labelLivrosEmprestados
            // 
            this.labelLivrosEmprestados.AutoSize = true;
            this.labelLivrosEmprestados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivrosEmprestados.Location = new System.Drawing.Point(33, 521);
            this.labelLivrosEmprestados.Name = "labelLivrosEmprestados";
            this.labelLivrosEmprestados.Size = new System.Drawing.Size(55, 19);
            this.labelLivrosEmprestados.TabIndex = 104;
            this.labelLivrosEmprestados.Text = "Obras";
            // 
            // buttonEditarObra
            // 
            this.buttonEditarObra.AutoEllipsis = true;
            this.buttonEditarObra.BackColor = System.Drawing.Color.Gold;
            this.buttonEditarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonEditarObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonEditarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEditarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonEditarObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonEditarObra.Location = new System.Drawing.Point(1142, 251);
            this.buttonEditarObra.Name = "buttonEditarObra";
            this.buttonEditarObra.Size = new System.Drawing.Size(82, 40);
            this.buttonEditarObra.TabIndex = 63;
            this.buttonEditarObra.Text = "Editar Obra";
            this.buttonEditarObra.UseVisualStyleBackColor = false;
            this.buttonEditarObra.Click += new System.EventHandler(this.buttonEditarObra_Click);
            // 
            // buttonDevolveObra
            // 
            this.buttonDevolveObra.AutoEllipsis = true;
            this.buttonDevolveObra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDevolveObra.BackColor = System.Drawing.Color.Gold;
            this.buttonDevolveObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDevolveObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonDevolveObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonDevolveObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonDevolveObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonDevolveObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDevolveObra.Location = new System.Drawing.Point(563, 516);
            this.buttonDevolveObra.Name = "buttonDevolveObra";
            this.buttonDevolveObra.Size = new System.Drawing.Size(83, 40);
            this.buttonDevolveObra.TabIndex = 25;
            this.buttonDevolveObra.Text = "Devolver Obra";
            this.buttonDevolveObra.UseVisualStyleBackColor = false;
            // 
            // buttonRenovarObra
            // 
            this.buttonRenovarObra.AutoEllipsis = true;
            this.buttonRenovarObra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRenovarObra.BackColor = System.Drawing.Color.Gold;
            this.buttonRenovarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRenovarObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonRenovarObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonRenovarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonRenovarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonRenovarObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonRenovarObra.Location = new System.Drawing.Point(652, 516);
            this.buttonRenovarObra.Name = "buttonRenovarObra";
            this.buttonRenovarObra.Size = new System.Drawing.Size(83, 40);
            this.buttonRenovarObra.TabIndex = 26;
            this.buttonRenovarObra.Text = "Renovar Obra";
            this.buttonRenovarObra.UseVisualStyleBackColor = false;
            // 
            // buttonReservarObra
            // 
            this.buttonReservarObra.AutoEllipsis = true;
            this.buttonReservarObra.BackColor = System.Drawing.Color.Gold;
            this.buttonReservarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservarObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonReservarObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonReservarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonReservarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonReservarObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonReservarObra.Location = new System.Drawing.Point(1002, 307);
            this.buttonReservarObra.Name = "buttonReservarObra";
            this.buttonReservarObra.Size = new System.Drawing.Size(82, 40);
            this.buttonReservarObra.TabIndex = 65;
            this.buttonReservarObra.Text = "Reservar Obra";
            this.buttonReservarObra.UseVisualStyleBackColor = false;
            // 
            // buttonEmprestarObra
            // 
            this.buttonEmprestarObra.AutoEllipsis = true;
            this.buttonEmprestarObra.BackColor = System.Drawing.Color.Gold;
            this.buttonEmprestarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmprestarObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonEmprestarObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonEmprestarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEmprestarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonEmprestarObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonEmprestarObra.Location = new System.Drawing.Point(914, 307);
            this.buttonEmprestarObra.Name = "buttonEmprestarObra";
            this.buttonEmprestarObra.Size = new System.Drawing.Size(82, 40);
            this.buttonEmprestarObra.TabIndex = 64;
            this.buttonEmprestarObra.Text = "Emprestar Obra";
            this.buttonEmprestarObra.UseVisualStyleBackColor = false;
            // 
            // labelLeitoresCadastrados
            // 
            this.labelLeitoresCadastrados.AutoSize = true;
            this.labelLeitoresCadastrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeitoresCadastrados.Location = new System.Drawing.Point(33, 256);
            this.labelLeitoresCadastrados.Name = "labelLeitoresCadastrados";
            this.labelLeitoresCadastrados.Size = new System.Drawing.Size(71, 19);
            this.labelLeitoresCadastrados.TabIndex = 201;
            this.labelLeitoresCadastrados.Text = "Leitores";
            // 
            // labelLivrosCadastrados
            // 
            this.labelLivrosCadastrados.AutoSize = true;
            this.labelLivrosCadastrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivrosCadastrados.Location = new System.Drawing.Point(777, 309);
            this.labelLivrosCadastrados.Name = "labelLivrosCadastrados";
            this.labelLivrosCadastrados.Size = new System.Drawing.Size(55, 19);
            this.labelLivrosCadastrados.TabIndex = 202;
            this.labelLivrosCadastrados.Text = "Obras";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1079, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(56, 20);
            this.textBoxId.TabIndex = 203;
            this.textBoxId.Visible = false;
            // 
            // textBoxIdLeitor
            // 
            this.textBoxIdLeitor.Location = new System.Drawing.Point(679, 12);
            this.textBoxIdLeitor.Name = "textBoxIdLeitor";
            this.textBoxIdLeitor.Size = new System.Drawing.Size(56, 20);
            this.textBoxIdLeitor.TabIndex = 204;
            this.textBoxIdLeitor.Visible = false;
            // 
            // buttonInativaLeitor
            // 
            this.buttonInativaLeitor.AutoEllipsis = true;
            this.buttonInativaLeitor.BackColor = System.Drawing.Color.Red;
            this.buttonInativaLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInativaLeitor.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonInativaLeitor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonInativaLeitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonInativaLeitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonInativaLeitor.ForeColor = System.Drawing.Color.White;
            this.buttonInativaLeitor.Location = new System.Drawing.Point(459, 251);
            this.buttonInativaLeitor.Name = "buttonInativaLeitor";
            this.buttonInativaLeitor.Size = new System.Drawing.Size(82, 40);
            this.buttonInativaLeitor.TabIndex = 20;
            this.buttonInativaLeitor.Text = "Inativar Leitor";
            this.buttonInativaLeitor.UseVisualStyleBackColor = false;
            this.buttonInativaLeitor.Click += new System.EventHandler(this.buttonInativaLeitor_Click);
            // 
            // buttonObrasInativas
            // 
            this.buttonObrasInativas.AutoEllipsis = true;
            this.buttonObrasInativas.BackColor = System.Drawing.Color.IndianRed;
            this.buttonObrasInativas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonObrasInativas.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonObrasInativas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonObrasInativas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonObrasInativas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonObrasInativas.ForeColor = System.Drawing.Color.White;
            this.buttonObrasInativas.Location = new System.Drawing.Point(1177, 307);
            this.buttonObrasInativas.Name = "buttonObrasInativas";
            this.buttonObrasInativas.Size = new System.Drawing.Size(82, 40);
            this.buttonObrasInativas.TabIndex = 67;
            this.buttonObrasInativas.Text = "Buscar Obras Inativas";
            this.buttonObrasInativas.UseVisualStyleBackColor = false;
            this.buttonObrasInativas.Click += new System.EventHandler(this.buttonObrasInativas_Click);
            // 
            // buttonLeitorInativo
            // 
            this.buttonLeitorInativo.AutoEllipsis = true;
            this.buttonLeitorInativo.BackColor = System.Drawing.Color.IndianRed;
            this.buttonLeitorInativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeitorInativo.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonLeitorInativo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonLeitorInativo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonLeitorInativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonLeitorInativo.ForeColor = System.Drawing.Color.White;
            this.buttonLeitorInativo.Location = new System.Drawing.Point(548, 251);
            this.buttonLeitorInativo.Name = "buttonLeitorInativo";
            this.buttonLeitorInativo.Size = new System.Drawing.Size(88, 40);
            this.buttonLeitorInativo.TabIndex = 21;
            this.buttonLeitorInativo.Text = "Buscar Leitores Inativos";
            this.buttonLeitorInativo.UseVisualStyleBackColor = false;
            this.buttonLeitorInativo.Click += new System.EventHandler(this.buttonLeitorInativo_Click);
            // 
            // buttonReativarObra
            // 
            this.buttonReativarObra.AutoEllipsis = true;
            this.buttonReativarObra.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReativarObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReativarObra.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonReativarObra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonReativarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonReativarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonReativarObra.ForeColor = System.Drawing.Color.White;
            this.buttonReativarObra.Location = new System.Drawing.Point(1265, 307);
            this.buttonReativarObra.Name = "buttonReativarObra";
            this.buttonReativarObra.Size = new System.Drawing.Size(82, 40);
            this.buttonReativarObra.TabIndex = 68;
            this.buttonReativarObra.Text = "Reativar Obra Inativa";
            this.buttonReativarObra.UseVisualStyleBackColor = false;
            this.buttonReativarObra.Click += new System.EventHandler(this.buttonReativarObra_Click);
            // 
            // buttonReativarLeitor
            // 
            this.buttonReativarLeitor.AutoEllipsis = true;
            this.buttonReativarLeitor.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReativarLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReativarLeitor.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonReativarLeitor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.buttonReativarLeitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonReativarLeitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonReativarLeitor.ForeColor = System.Drawing.Color.White;
            this.buttonReativarLeitor.Location = new System.Drawing.Point(642, 251);
            this.buttonReativarLeitor.Name = "buttonReativarLeitor";
            this.buttonReativarLeitor.Size = new System.Drawing.Size(93, 40);
            this.buttonReativarLeitor.TabIndex = 22;
            this.buttonReativarLeitor.Text = "Reativar Leitores Inativos";
            this.buttonReativarLeitor.UseVisualStyleBackColor = false;
            this.buttonReativarLeitor.Click += new System.EventHandler(this.buttonReativarLeitor_Click);
            // 
            // ColumnIdE
            // 
            this.ColumnIdE.HeaderText = "Id";
            this.ColumnIdE.Name = "ColumnIdE";
            this.ColumnIdE.Width = 30;
            // 
            // ColumnTituloE
            // 
            this.ColumnTituloE.HeaderText = "Título";
            this.ColumnTituloE.Name = "ColumnTituloE";
            this.ColumnTituloE.Width = 210;
            // 
            // ColumnAutorE
            // 
            this.ColumnAutorE.HeaderText = "Autor";
            this.ColumnAutorE.Name = "ColumnAutorE";
            this.ColumnAutorE.Width = 170;
            // 
            // ColumnValorE
            // 
            this.ColumnValorE.HeaderText = "Valor (R$)";
            this.ColumnValorE.Name = "ColumnValorE";
            // 
            // ColumnAnoE
            // 
            this.ColumnAnoE.HeaderText = "Ano";
            this.ColumnAnoE.Name = "ColumnAnoE";
            this.ColumnAnoE.Width = 70;
            // 
            // ColumnDataDevolucao
            // 
            this.ColumnDataDevolucao.HeaderText = "Devolução";
            this.ColumnDataDevolucao.Name = "ColumnDataDevolucao";
            // 
            // ColumnIdL
            // 
            this.ColumnIdL.HeaderText = "Id";
            this.ColumnIdL.Name = "ColumnIdL";
            this.ColumnIdL.Width = 25;
            // 
            // ColumnTituloL
            // 
            this.ColumnTituloL.HeaderText = "Título";
            this.ColumnTituloL.Name = "ColumnTituloL";
            this.ColumnTituloL.Width = 180;
            // 
            // ColumnValorL
            // 
            this.ColumnValorL.HeaderText = "Valor (R$)";
            this.ColumnValorL.Name = "ColumnValorL";
            this.ColumnValorL.Width = 40;
            // 
            // ColumnAnoL
            // 
            this.ColumnAnoL.HeaderText = "Ano";
            this.ColumnAnoL.Name = "ColumnAnoL";
            this.ColumnAnoL.Width = 35;
            // 
            // ColumnQuantidadeL
            // 
            this.ColumnQuantidadeL.HeaderText = "Qtdade";
            this.ColumnQuantidadeL.Name = "ColumnQuantidadeL";
            this.ColumnQuantidadeL.Width = 45;
            // 
            // ColumnAutorL
            // 
            this.ColumnAutorL.HeaderText = "Autor";
            this.ColumnAutorL.Name = "ColumnAutorL";
            this.ColumnAutorL.Width = 120;
            // 
            // ColumnGenero
            // 
            this.ColumnGenero.HeaderText = "Gênero";
            this.ColumnGenero.Name = "ColumnGenero";
            this.ColumnGenero.Width = 90;
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.HeaderText = "Descrição";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.Width = 80;
            // 
            // ColumnAtivoL
            // 
            this.ColumnAtivoL.HeaderText = "Ativo";
            this.ColumnAtivoL.Name = "ColumnAtivoL";
            this.ColumnAtivoL.Width = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 205;
            this.label1.Text = "Cadastradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 206;
            this.label2.Text = "Cadastrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 207;
            this.label3.Text = "Emprestadas";
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            this.columnId.Width = 30;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.Width = 85;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 150;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.Width = 90;
            // 
            // ColumnWhatsapp
            // 
            this.ColumnWhatsapp.HeaderText = "WhatsApp";
            this.ColumnWhatsapp.Name = "ColumnWhatsapp";
            this.ColumnWhatsapp.Width = 90;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 140;
            // 
            // ColumnFormaEnvio
            // 
            this.ColumnFormaEnvio.HeaderText = "Forma de Contato";
            this.ColumnFormaEnvio.Name = "ColumnFormaEnvio";
            this.ColumnFormaEnvio.Width = 65;
            // 
            // ColumnRua
            // 
            this.ColumnRua.HeaderText = "Rua";
            this.ColumnRua.Name = "ColumnRua";
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Nº";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.Width = 30;
            // 
            // ColumnComplemento
            // 
            this.ColumnComplemento.HeaderText = "Compl.";
            this.ColumnComplemento.Name = "ColumnComplemento";
            this.ColumnComplemento.Width = 55;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.HeaderText = "Bairro";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.Width = 50;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.Width = 50;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "UF";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.Width = 25;
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.Width = 60;
            // 
            // ColumnLimiteObrasLeitor
            // 
            this.ColumnLimiteObrasLeitor.HeaderText = "Limite";
            this.ColumnLimiteObrasLeitor.Name = "ColumnLimiteObrasLeitor";
            this.ColumnLimiteObrasLeitor.Width = 50;
            // 
            // ColumnAtivo
            // 
            this.ColumnAtivo.HeaderText = "Ativo";
            this.ColumnAtivo.Name = "ColumnAtivo";
            this.ColumnAtivo.Width = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1359, 705);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReativarLeitor);
            this.Controls.Add(this.buttonReativarObra);
            this.Controls.Add(this.buttonLeitorInativo);
            this.Controls.Add(this.buttonObrasInativas);
            this.Controls.Add(this.buttonInativaLeitor);
            this.Controls.Add(this.textBoxIdLeitor);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelLivrosCadastrados);
            this.Controls.Add(this.labelLeitoresCadastrados);
            this.Controls.Add(this.buttonEmprestarObra);
            this.Controls.Add(this.buttonReservarObra);
            this.Controls.Add(this.buttonRenovarObra);
            this.Controls.Add(this.buttonDevolveObra);
            this.Controls.Add(this.buttonEditarObra);
            this.Controls.Add(this.labelLivrosEmprestados);
            this.Controls.Add(this.dataGridViewEmprestimo);
            this.Controls.Add(this.maskedTextBoxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonLimparObra);
            this.Controls.Add(this.buttonBuscarObra);
            this.Controls.Add(this.buttonCadastrarObra);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.maskedTextBoxAno);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelCadastroLivro);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonPendencias);
            this.Controls.Add(this.buttonAlterarLimite);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.comboBoxEstados);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textBoxComplemento);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.maskedTextBoxWhatsApp);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxEnvio);
            this.Controls.Add(this.labelFormaEnvio);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelCadastroLeitor);
            this.Controls.Add(this.labelWhatsApp);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelRua);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dataGridViewLivros);
            this.Controls.Add(this.dataGridViewLeitor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLeitor;
        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelWhatsApp;
        private System.Windows.Forms.Label labelCadastroLeitor;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelFormaEnvio;
        private System.Windows.Forms.ComboBox comboBoxEnvio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWhatsApp;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAlterarLimite;
        private System.Windows.Forms.Button buttonPendencias;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelCadastroLivro;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAno;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Button buttonCadastrarObra;
        private System.Windows.Forms.Button buttonBuscarObra;
        private System.Windows.Forms.Button buttonLimparObra;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.Label labelLivrosEmprestados;
        private System.Windows.Forms.Button buttonEditarObra;
        private System.Windows.Forms.Button buttonDevolveObra;
        private System.Windows.Forms.Button buttonRenovarObra;
        private System.Windows.Forms.Button buttonReservarObra;
        private System.Windows.Forms.Button buttonEmprestarObra;
        private System.Windows.Forms.Label labelLeitoresCadastrados;
        private System.Windows.Forms.Label labelLivrosCadastrados;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxIdLeitor;
        private System.Windows.Forms.Button buttonInativaLeitor;
        private System.Windows.Forms.Button buttonObrasInativas;
        private System.Windows.Forms.Button buttonLeitorInativo;
        private System.Windows.Forms.Button buttonReativarObra;
        private System.Windows.Forms.Button buttonReativarLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTituloE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutorE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTituloL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnoL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutorL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtivoL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhatsapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormaEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLimiteObrasLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtivo;
    }
}

