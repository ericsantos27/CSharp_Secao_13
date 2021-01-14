using System;
using System.IO;
using System.Collections.Generic;

namespace Secao_13_Aula_190_Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Public\MyFolder";

            try
            {
                // Código para listar as pastas que constam em um diretório na rede
                IEnumerable<string> folders = Directory.EnumerateDirectories(filePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas listadas: ");
                foreach(string element in folders)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine();

                // Código para listar os arquivos que constam em uma pasta na rede
                IEnumerable<string> files = Directory.EnumerateFiles(filePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos listados: ");
                foreach(string element in files)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine();

                // Código para criar uma nova pasta na rede a partir de uma determinada pasta
                Directory.CreateDirectory(@"C:\Users\Public\MyFolder\NewCSharpFolder");
                Console.WriteLine("Pasta criada com sucesso");
            }
            catch(IOException except)
            {
                Console.WriteLine("Erro: {0}", except.Message);
            }
        }
    }
}
