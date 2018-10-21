namespace WIMP_Personas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtConteudo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipoSelecionado = new System.Windows.Forms.TextBox();
            this.RbOutros = new System.Windows.Forms.RadioButton();
            this.RbNoticia = new System.Windows.Forms.RadioButton();
            this.RbArtigo = new System.Windows.Forms.RadioButton();
            this.RbMusica = new System.Windows.Forms.RadioButton();
            this.RbVideo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAssunto = new System.Windows.Forms.TextBox();
            this.ListaFavoritos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaDados = new System.Windows.Forms.Label();
            this.dataGridListaFavoritos = new System.Windows.Forms.DataGridView();
            this.iDFavoritoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkConteudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFavoritosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDFavoritosDataSet = new WIMP_Personas.BDFavoritosDataSet();
            this.tblFavoritosTableAdapter = new WIMP_Personas.BDFavoritosDataSetTableAdapters.tblFavoritosTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFavoritosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFavoritosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtConteudo
            // 
            this.TxtConteudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConteudo.Location = new System.Drawing.Point(40, 167);
            this.TxtConteudo.Name = "TxtConteudo";
            this.TxtConteudo.Size = new System.Drawing.Size(486, 22);
            this.TxtConteudo.TabIndex = 1;
            this.TxtConteudo.Tag = "";
            this.TxtConteudo.Text = "http://";
            this.TxtConteudo.TextChanged += new System.EventHandler(this.TxtConteudo_TextChanged);
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.Location = new System.Drawing.Point(37, 151);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(180, 16);
            this.lblConteudo.TabIndex = 2;
            this.lblConteudo.Text = "Link que desejo guardar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoSelecionado);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.RbOutros);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.RbNoticia);
            this.groupBox1.Controls.Add(this.RbArtigo);
            this.groupBox1.Controls.Add(this.RbMusica);
            this.groupBox1.Controls.Add(this.RbVideo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do Conteúdo";
            // 
            // txtTipoSelecionado
            // 
            this.txtTipoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoSelecionado.Location = new System.Drawing.Point(15, 44);
            this.txtTipoSelecionado.Name = "txtTipoSelecionado";
            this.txtTipoSelecionado.Size = new System.Drawing.Size(129, 22);
            this.txtTipoSelecionado.TabIndex = 10;
            this.txtTipoSelecionado.Tag = "";
            this.txtTipoSelecionado.Visible = false;
            // 
            // RbOutros
            // 
            this.RbOutros.AutoSize = true;
            this.RbOutros.Location = new System.Drawing.Point(608, 26);
            this.RbOutros.Name = "RbOutros";
            this.RbOutros.Size = new System.Drawing.Size(71, 20);
            this.RbOutros.TabIndex = 7;
            this.RbOutros.TabStop = true;
            this.RbOutros.Text = "Outros";
            this.RbOutros.UseVisualStyleBackColor = true;
            this.RbOutros.CheckedChanged += new System.EventHandler(this.RbOutros_CheckedChanged);
            // 
            // RbNoticia
            // 
            this.RbNoticia.AutoSize = true;
            this.RbNoticia.Location = new System.Drawing.Point(469, 26);
            this.RbNoticia.Name = "RbNoticia";
            this.RbNoticia.Size = new System.Drawing.Size(75, 20);
            this.RbNoticia.TabIndex = 6;
            this.RbNoticia.TabStop = true;
            this.RbNoticia.Text = "Notícia";
            this.RbNoticia.UseVisualStyleBackColor = true;
            this.RbNoticia.CheckedChanged += new System.EventHandler(this.RbNoticia_CheckedChanged);
            // 
            // RbArtigo
            // 
            this.RbArtigo.AutoSize = true;
            this.RbArtigo.Location = new System.Drawing.Point(273, 26);
            this.RbArtigo.Name = "RbArtigo";
            this.RbArtigo.Size = new System.Drawing.Size(135, 20);
            this.RbArtigo.TabIndex = 5;
            this.RbArtigo.TabStop = true;
            this.RbArtigo.Text = "Artigo Científico";
            this.RbArtigo.UseVisualStyleBackColor = true;
            this.RbArtigo.CheckedChanged += new System.EventHandler(this.RbArtigo_CheckedChanged);
            // 
            // RbMusica
            // 
            this.RbMusica.AutoSize = true;
            this.RbMusica.Location = new System.Drawing.Point(140, 26);
            this.RbMusica.Name = "RbMusica";
            this.RbMusica.Size = new System.Drawing.Size(75, 20);
            this.RbMusica.TabIndex = 4;
            this.RbMusica.TabStop = true;
            this.RbMusica.Text = "Música";
            this.RbMusica.UseVisualStyleBackColor = true;
            this.RbMusica.CheckedChanged += new System.EventHandler(this.RbMusica_CheckedChanged);
            // 
            // RbVideo
            // 
            this.RbVideo.AutoSize = true;
            this.RbVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RbVideo.Location = new System.Drawing.Point(15, 26);
            this.RbVideo.Name = "RbVideo";
            this.RbVideo.Size = new System.Drawing.Size(67, 20);
            this.RbVideo.TabIndex = 3;
            this.RbVideo.TabStop = true;
            this.RbVideo.Text = "Vídeo";
            this.RbVideo.UseVisualStyleBackColor = true;
            this.RbVideo.CheckedChanged += new System.EventHandler(this.RbVideo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assunto:";
            // 
            // TxtAssunto
            // 
            this.TxtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAssunto.Location = new System.Drawing.Point(535, 167);
            this.TxtAssunto.Name = "TxtAssunto";
            this.TxtAssunto.Size = new System.Drawing.Size(221, 22);
            this.TxtAssunto.TabIndex = 2;
            this.TxtAssunto.Tag = "";
            // 
            // ListaFavoritos
            // 
            this.ListaFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaFavoritos.FormattingEnabled = true;
            this.ListaFavoritos.ItemHeight = 16;
            this.ListaFavoritos.Location = new System.Drawing.Point(40, 326);
            this.ListaFavoritos.Name = "ListaFavoritos";
            this.ListaFavoritos.Size = new System.Drawing.Size(716, 68);
            this.ListaFavoritos.Sorted = true;
            this.ListaFavoritos.TabIndex = 10;
            this.ListaFavoritos.Tag = "";
            this.ListaFavoritos.SelectedIndexChanged += new System.EventHandler(this.LbFavoritos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Meus Favoritos:";
            // 
            // ListaDados
            // 
            this.ListaDados.AutoSize = true;
            this.ListaDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDados.Location = new System.Drawing.Point(310, 303);
            this.ListaDados.Name = "ListaDados";
            this.ListaDados.Size = new System.Drawing.Size(0, 20);
            this.ListaDados.TabIndex = 13;
            // 
            // dataGridListaFavoritos
            // 
            this.dataGridListaFavoritos.AllowUserToOrderColumns = true;
            this.dataGridListaFavoritos.AutoGenerateColumns = false;
            this.dataGridListaFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaFavoritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFavoritoDataGridViewTextBoxColumn,
            this.linkConteudoDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridListaFavoritos.DataSource = this.tblFavoritosBindingSource;
            this.dataGridListaFavoritos.Location = new System.Drawing.Point(40, 450);
            this.dataGridListaFavoritos.Name = "dataGridListaFavoritos";
            this.dataGridListaFavoritos.ReadOnly = true;
            this.dataGridListaFavoritos.Size = new System.Drawing.Size(544, 100);
            this.dataGridListaFavoritos.TabIndex = 14;
            // 
            // iDFavoritoDataGridViewTextBoxColumn
            // 
            this.iDFavoritoDataGridViewTextBoxColumn.DataPropertyName = "IDFavorito";
            this.iDFavoritoDataGridViewTextBoxColumn.HeaderText = "IDFavorito";
            this.iDFavoritoDataGridViewTextBoxColumn.Name = "iDFavoritoDataGridViewTextBoxColumn";
            this.iDFavoritoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkConteudoDataGridViewTextBoxColumn
            // 
            this.linkConteudoDataGridViewTextBoxColumn.DataPropertyName = "linkConteudo";
            this.linkConteudoDataGridViewTextBoxColumn.HeaderText = "linkConteudo";
            this.linkConteudoDataGridViewTextBoxColumn.Name = "linkConteudoDataGridViewTextBoxColumn";
            this.linkConteudoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblFavoritosBindingSource
            // 
            this.tblFavoritosBindingSource.DataMember = "tblFavoritos";
            this.tblFavoritosBindingSource.DataSource = this.bDFavoritosDataSet;
            // 
            // bDFavoritosDataSet
            // 
            this.bDFavoritosDataSet.DataSetName = "BDFavoritosDataSet";
            this.bDFavoritosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFavoritosTableAdapter
            // 
            this.tblFavoritosTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.Tag = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar:";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.AccessibleDescription = "Relatório";
            this.btnRelatorio.AccessibleName = "Guardar Favoritos";
            this.btnRelatorio.AllowDrop = true;
            this.btnRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorio.BackgroundImage = global::WIMP_Personas.Properties.Resources.icone_da_pasta_de_download_7253_21;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRelatorio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.Green;
            this.btnRelatorio.Location = new System.Drawing.Point(745, 58);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(113, 86);
            this.btnRelatorio.TabIndex = 17;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.AccessibleName = "Guardar Favoritos";
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackgroundImage = global::WIMP_Personas.Properties.Resources.logout256_24927;
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSair.Location = new System.Drawing.Point(839, 450);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(58, 56);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.AccessibleDescription = "";
            this.BtnImprimir.AccessibleName = "Guardar Favoritos";
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimir.BackgroundImage = global::WIMP_Personas.Properties.Resources.icone_da_pasta_de_download_7253_2;
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImprimir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnImprimir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.Blue;
            this.BtnImprimir.Location = new System.Drawing.Point(762, 326);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(71, 61);
            this.BtnImprimir.TabIndex = 9;
            this.BtnImprimir.Tag = "";
            this.BtnImprimir.Text = "Carregar";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WIMP_Personas.Properties.Resources.Logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WIMP_Personas.Properties.Resources.Outros_Icone;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(677, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WIMP_Personas.Properties.Resources.Noticias3_Icone;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(543, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WIMP_Personas.Properties.Resources.Artigo_Icone;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(406, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WIMP_Personas.Properties.Resources.Music_Icone;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(213, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WIMP_Personas.Properties.Resources.Video;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(81, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AccessibleName = "Guardar Favoritos";
            this.BtnGuardar.AllowDrop = true;
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackgroundImage = global::WIMP_Personas.Properties.Resources.Gravar_icone;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Green;
            this.BtnGuardar.Location = new System.Drawing.Point(762, 216);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(71, 64);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Salvar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 550);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridListaFavoritos);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.ListaDados);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaFavoritos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAssunto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.TxtConteudo);
            this.Controls.Add(this.BtnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "App Favoritos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFavoritosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFavoritosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtConteudo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.RadioButton RbVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAssunto;
        private System.Windows.Forms.RadioButton RbArtigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbNoticia;
        private System.Windows.Forms.ListBox ListaFavoritos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton RbOutros;
        private System.Windows.Forms.TextBox txtTipoSelecionado;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Label ListaDados;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView dataGridListaFavoritos;
        private BDFavoritosDataSet bDFavoritosDataSet;
        private System.Windows.Forms.BindingSource tblFavoritosBindingSource;
        private BDFavoritosDataSetTableAdapters.tblFavoritosTableAdapter tblFavoritosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFavoritoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkConteudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

