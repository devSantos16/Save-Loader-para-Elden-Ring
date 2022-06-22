using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveLoaderER.Classes
{
    internal class Arquivo
    {
        public string save_path { get; set; }
        public string all_save_path { get; set; }

        public Arquivo()
        {
            all_save_path = @"C:\Users\nel_2\OneDrive\Resto\Documentos\SAVEFILE_ELDENRING";
        }

        public string AcessarArquivosSalvado(string all_save_path)
        {
            string[] dirs = Directory.GetDirectories(all_save_path, "*", SearchOption.TopDirectoryOnly);
            string nomePasta = string.Empty;

            for (int i = 0; i < dirs.Length; i++)
            {
                nomePasta = dirs[i];
                string concat = all_save_path + "\\";
                nomePasta = nomePasta.Replace(concat, "");
                return nomePasta;
            }

            return "Erro";
        }

        public void AdicionarPastaEArquivos(string save_path, string all_save_path)
        {

            string[] files = Directory.GetFiles(save_path);
            string nomeArquivo, caminhoArquivo;

            int numeroAspasDiretorio = save_path.Split(@"\").Length;
            string novoDiretorioArquivoEldenRing = all_save_path + @"\" + save_path.Split(@"\")[numeroAspasDiretorio - 1];

            Directory.CreateDirectory(novoDiretorioArquivoEldenRing);
            foreach (string file in files)
            {
                nomeArquivo = Path.GetFileName(file);
                caminhoArquivo = Path.Combine(novoDiretorioArquivoEldenRing, nomeArquivo);
                File.Copy(file, caminhoArquivo, true);
            }
        }
    }
}
