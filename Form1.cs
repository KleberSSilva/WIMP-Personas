using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIMP_Personas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {           
            //(favoritos.getLinkConteudo(), favoritos.getAssunto());
            Favoritos favoritos;
            favoritos = new Favoritos(TxtConteudo.Text, TxtAssunto.Text, txtTipoSelecionado.Text, DateTime.Now);

            /*ListaFavoritos.MultiColumn = true;
            ListaFavoritos.Items.AddRange(new object[]
            {
                favoritos.GetLinkConteudo(), favoritos.GetAssunto(), favoritos.GettipoConteudo(),
            });*/
            // Grava os dados
            ManipulaArquivo.writeData(TxtConteudo.Text, TxtAssunto.Text, txtTipoSelecionado.Text, DateTime.Now);

            // Exibe uma mensagem informando que os dados foram gravados.

            //ListaDados.Text = "Dados gravados com sucesso!!!";

            TxtConteudo.Text = "http://";
            TxtAssunto.Text = null;
            txtTipoSelecionado.Text = null;
        }

        private void RbVideo_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoSelecionado.Text = RbVideo.Text;
        }

        private void RbMusica_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoSelecionado.Text = RbMusica.Text;
        }

        private void RbArtigo_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoSelecionado.Text = RbArtigo.Text;
        }

        private void RbNoticia_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoSelecionado.Text = RbNoticia.Text;
        }

        private void RbOutros_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoSelecionado.Text = RbOutros.Text;
        }

        private void LbFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Imprimir_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //ListaDados.Text = "";
            ListaFavoritos.Items.Clear();

            string[] arquivo = ManipulaArquivo.ImprimeArquivo();
                        
            foreach (String linha in arquivo)
            {
                //ListaDados.Text = ListaDados.Text + linha + "\n";
                if (linha!=null)
                    ListaFavoritos.Items.Add(linha);
            }           
        }
        private void ListaConteudo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtConteudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDataGrid_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioDataGrid form = new frmRelatorioDataGrid();
            form.Show();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDFavoritosDataSet.tblFavoritos'. Você pode movê-la ou removê-la conforme necessário.
            this.tblFavoritosTableAdapter.Fill(this.bDFavoritosDataSet.tblFavoritos);
            //outro comentário
        }*/
    }
}
