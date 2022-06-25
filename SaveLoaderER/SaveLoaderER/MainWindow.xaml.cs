using SaveLoaderER.Classes;
using System.Collections.Generic;
using System.Windows;


namespace SaveLoaderER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Arquivo InitializeArchive = new Arquivo();

            // string[] lista = InitializeArchive.AcessarArquivosSalvo();
            List<string> lista = InitializeArchive.AcessarArquivosSalvo();

            foreach(string listaArquivos in lista)
            {
                Arquivo a = new Arquivo();
                a.name_path = listaArquivos;
                AdicionarItemTOControle(a);
            }
            
          




        }

        private void AdicionarItemTOControle(Arquivo SaveFile)
        {
            UserControl1 user = new UserControl1(SaveFile.name_path, SaveFile.all_save_path);
            Painel.Children.Add(user);
            
        }

        private void Selecionar_Arquivo_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Forms.FolderBrowserDialog file = new System.Windows.Forms.FolderBrowserDialog();
            file.ShowDialog();
            string pastaSelecionada = file.SelectedPath;

            Arquivo SaveFile = new Arquivo();
            SaveFile.save_path = pastaSelecionada;

            SaveFile.AdicionarPastaEArquivos(SaveFile.save_path);
            AdicionarItemTOControle(SaveFile);


        }
    }
}
