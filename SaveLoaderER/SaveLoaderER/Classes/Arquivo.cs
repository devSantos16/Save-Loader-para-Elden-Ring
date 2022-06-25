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
        public string name_path { get; set; }

        public Arquivo()
        {
            all_save_path = @"E:\Projetos\SaveLoaderER\Save Loader para Elden Ring\SaveLoaderER\SaveLoaderER\bin\Debug\path_archive";
        }

        public List<string> AcessarArquivosSalvo()
        {
            // IDictionary<int, string> dict = new Dictionary<int, string>();
            string[] dirs = Directory.GetDirectories(all_save_path, "*", SearchOption.TopDirectoryOnly);
            List<string> all_name_path = new List<string>();

            foreach(string lista in dirs)
            {
                int numeroAspasDiretorio = all_save_path.Split(@"\").Length;
                name_path = lista.Split(@"\")[numeroAspasDiretorio];
                all_name_path.Add(name_path);
            }

            return all_name_path;

        }

        public void AdicionarPastaEArquivos(string save_path)
        {
            string[] files = Directory.GetFiles(save_path);
            string nomeArquivo, caminhoArquivo;
            //vou usar alguma hora
            //
            //string novoDiretorioArquivoEldenRing = all_save_path + @"\" + save_path.Split(@"\")[numeroAspasDiretorio - 1];

            string novoDiretorioArquivoEldenRing = all_save_path + @"\" + RetornarNomeString();

            
            Directory.CreateDirectory(novoDiretorioArquivoEldenRing);
            foreach (string file in files)
            {
                nomeArquivo = Path.GetFileName(file);
                caminhoArquivo = Path.Combine(novoDiretorioArquivoEldenRing, nomeArquivo);
                File.Copy(file, caminhoArquivo, true);
            }
        }
        public string RetornarNomeString()
        {
            string[] dirs = Directory.GetDirectories(all_save_path, "*", SearchOption.TopDirectoryOnly);

            name_path = "SAVEFILE_ELDEN_RING_" + dirs.Length;

            return name_path;
        }
    }
}
