using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIMP_Personas
{
    class ManipulaArquivo
    {
        private static string _file = (@"C:/Users/Public/Downloads/preferencias.txt");

        //Método que cria o arquivo txt caso ele não exista, Void por que não retorna nada.
        private static void verifyFile()
        {
            if (!File.Exists(_file))
                //Verifica se o arquivo existe, retorna true, neguei a condição, 
                //então se o arquivo não existir ele entra no IF.
            {
                File.Create(_file);
                //Cria um arquivo, no caso, cria o arquivo informado na variável _file.
            }
        }

        public static void writeData(String conteudo, String assunto, String tipoConteudo, DateTime data)
        {
            verifyFile(); //Chama nosso método que cria o arquivo caso ele não exista.

            StreamWriter streamW = new StreamWriter(_file, true);
            //Criamos um novo objeto do tipo StreamWriter, passamos o nome do nosso arquivo.

            streamW.WriteLine(conteudo + "," + assunto + "," + tipoConteudo + ","+ data);
            //Através do objeto streamW acessamos o método WriteLine 
            //e passamos os textos que queremos gravar.             
            streamW.Close();
            //Sempre que terminarem de ler e gravar em um arquivo é necessário fecha-lo, 
            //isto evita mutios erros.
            MessageBox.Show("Dados gravados com sucesso!!!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string[] ImprimeArquivo()
        {
            //imprime o conteudo do arquivo
            StreamReader leitor = null;
            int k = 0;
            string[] text = null;
            string[] linhas = null;
            try
            {                
                FileStream arquivo = new FileStream(@"C:/Users/Public/Downloads/preferencias.txt", FileMode.Open);
                

                leitor = new StreamReader(arquivo);
                //le os dados do arquivo e armazena na variavel

                string linha = leitor.ReadLine();
                //linhas = new string[System.IO.File.ReadAllLines(@"C:/Users/Public/Downloads/preferencias.txt").Length];
                linhas = new string[linha.Length];

                while (linha != null && linha.Length != 0)
                {
                    linhas[k++] = linha;
                    linha = leitor.ReadLine();
                }
                arquivo.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo  não encontrado!");
            }
            catch (IOException)
            {
                Console.WriteLine("Problema com o arquivo.");
            }
            text = new string[k];
            text=linhas;
            return linhas;
            
        }
    }
}

