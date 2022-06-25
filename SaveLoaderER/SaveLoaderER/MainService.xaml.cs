using System;
using System.Collections.Generic;
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
    /// Interação lógica para UserControl1.xam
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string nome_pasta, string caminho_diretorio)
        {
            InitializeComponent();
            NomeArquivo.Content = nome_pasta;
            CaminhoDiretorio.Content = caminho_diretorio + @"\" + nome_pasta;
            //NomeArquivo.Content = caminho_diretorio + @"\" + nome_pasta;
        }
    }
}
