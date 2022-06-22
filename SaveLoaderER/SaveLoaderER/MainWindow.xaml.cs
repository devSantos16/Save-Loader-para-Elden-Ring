using SaveLoaderER.Classes;
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
        private const string DIRETORIO_ARQUIVO_SAVE = @"C:\Users\nel_2\OneDrive\Resto\Área de Trabalho\76561198900787417";

        public MainWindow()
        {
            InitializeComponent();

            Arquivo SaveFile = new Arquivo();
            SaveFile.save_path = DIRETORIO_ARQUIVO_SAVE;

            SaveFile.AdicionarPastaEArquivos(SaveFile.save_path, SaveFile.all_save_path);
            SaveFile.AcessarArquivosSalvado(SaveFile.save_path);
            



        }
    }
}
