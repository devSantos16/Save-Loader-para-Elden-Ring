using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SaveLoaderER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string DIRETORIO_ARQUIVO_ELDEN_RING = @"C:\Users\nel_2\OneDrive\Resto\Documentos\SAVEFILE_ELDENRING";
        private const string DIRETORIO_ARQUIVO_SAVE = @"C:\Users\nel_2\OneDrive\Resto\Área de Trabalho\76561198900787417";


        //private const string DIRETORIO_ARQUIVO_CACHE = @"C:\Users\nel_2\AppData\Roaming\SAVEFILE_ELDENRING_CACHE";

        public MainWindow()
        {
            InitializeComponent();

            AdicionarPastaEArquivos(DIRETORIO_ARQUIVO_SAVE, DIRETORIO_ARQUIVO_ELDEN_RING);
            AcessarArquivos(DIRETORIO_ARQUIVO_ELDEN_RING);
        }

        private static string AcessarArquivos(string diretorioArquivo)
        {
            string[] dirs = Directory.GetDirectories(diretorioArquivo, "*", SearchOption.TopDirectoryOnly);
            string nomePasta = string.Empty;

            for (int i = 0; i < dirs.Length; i++)
            {
                nomePasta = dirs[i];
                string concat = diretorioArquivo + "\\";
                nomePasta = nomePasta.Replace(concat, "");
                return nomePasta;
            }

            return "Erro";
        }

        private static void AdicionarPastaEArquivos(string diretorioArquivoSave, string diretorioArquivoEldenRing)
        {  

            string[] files = Directory.GetFiles(diretorioArquivoSave);
            string nomeArquivo, caminhoArquivo;

            int numeroAspasDiretorio = diretorioArquivoSave.Split(@"\").Length;
            string novoDiretorioArquivoEldenRing = diretorioArquivoEldenRing + @"\" + diretorioArquivoSave.Split(@"\")[numeroAspasDiretorio - 1];

            Directory.CreateDirectory(novoDiretorioArquivoEldenRing);
            foreach (string file in files)
            {
                nomeArquivo = System.IO.Path.GetFileName(file);
                caminhoArquivo = System.IO.Path.Combine(novoDiretorioArquivoEldenRing, nomeArquivo);
                File.Copy(file, caminhoArquivo, true);
            }   
        }
    }
}
