﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WIMP_Personas
{
    public partial class frmRelatorioDataGrid : Form
    {
        //public partial class frmRelatorioDataGrid : Form
        //{
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        //private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();

        public frmRelatorioDataGrid()
        {
            this.Load += new EventHandler(frmRelatorioDataGrid_Load);
        }

        private void frmRelatorioDataGrid_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();

            // TODO: esta linha de código carrega dados na tabela 'bDFavoritosDataSet.tblFavoritos'. Você pode movê-la ou removê-la conforme necessário.
            //this.tblFavoritosTableAdapter.Fill(this.bDFavoritosDataSet.tblFavoritos);
        }
        private void songsDataGridView_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.songsDataGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.songsDataGridView.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.songsDataGridView.SelectedRows.Count > 0 &&
                this.songsDataGridView.SelectedRows[0].Index !=
                this.songsDataGridView.Rows.Count - 1)
            {
                this.songsDataGridView.Rows.RemoveAt(
                    this.songsDataGridView.SelectedRows[0].Index);
            }
        }

        private void SetupLayout()
        {
            this.Size = new Size(600, 500);

            //addNewRowButton.Text = "Add Row";
            //addNewRowButton.Location = new Point(10, 10);
            //addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Delete Row";
            deleteRowButton.Location = new Point(100, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            //buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(songsDataGridView);

            songsDataGridView.ColumnCount = 4;

            songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(songsDataGridView.Font, FontStyle.Bold);

            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.Location = new Point(8, 8);
            songsDataGridView.Size = new Size(500, 250);
            songsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            songsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            songsDataGridView.GridColor = Color.Black;
            songsDataGridView.RowHeadersVisible = false;

            songsDataGridView.Columns[0].Name = "Web Site";
            songsDataGridView.Columns[1].Name = "Assunto";
            songsDataGridView.Columns[2].Name = "Tipo do Conteúdo";
            songsDataGridView.Columns[3].Name = "Data de Consulta";
            songsDataGridView.Columns[3].DefaultCellStyle.Font =
                new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            songsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            songsDataGridView.MultiSelect = false;
            songsDataGridView.Dock = DockStyle.Fill;

            songsDataGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {
            //ListaDados.Text = "";
            songsDataGridView.Rows.Clear();

            string[] arquivo = ManipulaArquivo.ImprimeArquivo();

            foreach (String linha in arquivo)
            {
                string row = linha;
                //ListaDados.Text = ListaDados.Text + linha + "\n";
                if (linha != null)
                    
                    songsDataGridView.Rows.Add(row);
            }

            /*string[] row0 = { "1960", "6", "Fools Rush In", "Frank Sinatra" };
            string[] row1 = { "1960", "6", "Fools Rush In","Frank Sinatra" };
            string[] row2 = { "11/11/1971", "1", "One of These Days","Pink Floyd"};
            string[] row3 = { "1988", "7", "Where Is My Mind?","Pixies"};
            string[] row4 = { "5/1981", "9", "Can't Find My Mind","Cramps" };
            string[] row5 = { "6/10/2003", "13","Scatterbrain. (As Dead As Leaves.)","Radiohead"};
            string[] row6 = { "30/06/1992", "3", "Dress", "P J Harvey"};

            songsDataGridView.Rows.Add(row0);
            songsDataGridView.Rows.Add(row1);
            songsDataGridView.Rows.Add(row2);
            songsDataGridView.Rows.Add(row3);
            songsDataGridView.Rows.Add(row4);
            songsDataGridView.Rows.Add(row5);
            songsDataGridView.Rows.Add(row6);*/

            songsDataGridView.Columns[0].DisplayIndex = 0;
            songsDataGridView.Columns[1].DisplayIndex = 1;
            songsDataGridView.Columns[2].DisplayIndex = 2;
            songsDataGridView.Columns[3].DisplayIndex = 3;
        }
    }
        //[STAThreadAttribute()]
        /*static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new frmRelatorioDataGrid());
        } */
}
