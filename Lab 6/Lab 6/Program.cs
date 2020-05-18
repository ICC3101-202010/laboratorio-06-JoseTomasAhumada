using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> company = new List<Company>();
            Console.WriteLine("¿Desea utilizar un archivo para cargar la información de la empresa? (si/no)");
            string option = Console.ReadLine();
            if (option == "no")
            {
                Console.WriteLine("Nombre de la empresa:");
                string name = Console.ReadLine();
                Console.WriteLine("Rut de la empresa (sin punto ni guión):");
                string rut = Console.ReadLine();
                company.Add(new Company(name, rut));
                Save(company);
            }
            Console.ReadKey();
        }
        static private void Save(List<Company> company)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, company);
            stream.Close();
        }
    }
}
