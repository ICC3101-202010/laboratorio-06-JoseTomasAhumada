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
                Console.WriteLine("\nNombre de la empresa:");
                string name = Console.ReadLine();
                Console.WriteLine("\nRut de la empresa (sin punto ni guión):");
                string rut = Console.ReadLine();
                Person person = new Person("", "", "", "");

                //Creando departamento.
                Console.WriteLine("\nNombre del departamento:");
                string Dname = Console.ReadLine();
                ////Creando a la persona encargada.
                Console.WriteLine("\nNombre de la persona encargada:");
                string PDname = Console.ReadLine();
                Console.WriteLine("\nApellido de la persona encargada:");
                string PDlastname = Console.ReadLine();
                Console.WriteLine("\nRUT de la persona encargada:");
                string PDrut = Console.ReadLine();
                Console.WriteLine("\nPosición de la persona encargada:");
                string PDposition = Console.ReadLine();
                Person pD = new Person(PDname, PDlastname, PDrut, PDposition);
                Department d = new Department(Dname, pD, person);

                //Creando sección.
                Console.WriteLine("\nNombre de la sección:");
                string Sname = Console.ReadLine();
                ////Creando a la persona encargada.
                Console.WriteLine("\nNombre de la persona encargada:");
                string PSname = Console.ReadLine();
                Console.WriteLine("\nApellido de la persona encargada:");
                string PSlastname = Console.ReadLine();
                Console.WriteLine("\nRUT de la persona encargada:");
                string PSrut = Console.ReadLine();
                Console.WriteLine("\nPosición de la persona encargada:");
                string PSposition = Console.ReadLine();
                Person pS = new Person(PSname, PSlastname, PSrut, PSposition);
                Section s = new Section(Sname, pS, person);

                //Creando bloque 1.
                Console.WriteLine("\nNombre del bloque 1:");
                string Bname = Console.ReadLine();
                ////Creando a la persona encargada.
                Console.WriteLine("\nNombre de la persona encargada:");
                string PBname = Console.ReadLine();
                Console.WriteLine("\nApellido de la persona encargada:");
                string PBlastname = Console.ReadLine();
                Console.WriteLine("\nRUT de la persona encargada:");
                string PBrut = Console.ReadLine();
                Console.WriteLine("\nPosición de la persona encargada:");
                string PBposition = Console.ReadLine();
                Person pB = new Person(PBname, PBlastname, PBrut, PBposition);
                ////Creando a la primera persona del personal general.
                Console.WriteLine("\nNombre de la persona 1:");
                string PB1name = Console.ReadLine();
                Console.WriteLine("\nApellido de la persona 1:");
                string PB1lastname = Console.ReadLine();
                Console.WriteLine("\nRUT de la persona 1:");
                string PB1rut = Console.ReadLine();
                Console.WriteLine("\nPosición de la persona 1:");
                string PB1position = Console.ReadLine();
                Person pB1 = new Person(PB1name, PB1lastname, PB1rut, PB1position);
                Block b11 = new Block(Bname, pB, pB1);
                ////Creando a la segunda persona del personal general.
                Console.WriteLine("\nNombre de la persona 2:");
                string PB2name = Console.ReadLine();
                Console.WriteLine("\nApellido de la persona 2:");
                string PB2lastname = Console.ReadLine();
                Console.WriteLine("\nRUT de la persona 2:");
                string PB2rut = Console.ReadLine();
                Console.WriteLine("\nPosición de la persona 2:");
                string PB2position = Console.ReadLine();
                Person pB2 = new Person(PB2name, PB2lastname, PB2rut, PB2position);
                Block b12 = new Block(Bname, pB, pB2);

                //Creando bloque 2.
                Console.WriteLine("\nNombre del bloque 2:");
                string B3name = Console.ReadLine();
                ////Creando a la primera persona del personal general.
                Console.WriteLine("\nNombre de la persona 1:");
                string PB13name = Console.ReadLine();
                Console.WriteLine("\nApellido de la persona 1:");
                string PB13lastname = Console.ReadLine();
                Console.WriteLine("\nRUT de la persona 1:");
                string PB13rut = Console.ReadLine();
                Console.WriteLine("\nPosición de la persona 1:");
                string PB13position = Console.ReadLine();
                Person pB13 = new Person(PB13name, PB13lastname, PB13rut, PB13position);
                Block b3 = new Block(B3name, pB, pB13);
                ////Creando a la segunda persona del personal general.
                Console.WriteLine("\nNombre de la persona 2:");
                string PB23name = Console.ReadLine();
                Console.WriteLine("\nApellido de la persona 2:");
                string PB23lastname = Console.ReadLine();
                Console.WriteLine("\nRUT de la persona 2:");
                string PB23rut = Console.ReadLine();
                Console.WriteLine("\nPosición de la persona 2:");
                string PB23position = Console.ReadLine();
                Person pB23 = new Person(PB23name, PB23lastname, PB23rut, PB23position);
                Block b4 = new Block(B3name, pB, pB23);

                //agrupando las divisiones de la empresa.
                List<Division> divisions = new List<Division>();
                divisions.Add(d);
                divisions.Add(s);
                divisions.Add(b11);
                divisions.Add(b12);
                divisions.Add(b3);
                divisions.Add(b4);
                company.Add(new Company(name, rut, divisions));
                Save(company);
            }
            if (option == "si")
            {
                try
                {
                    int a = 1;
                    company = Load();
                    Console.WriteLine("\nEl archivo se cargó correctamente.");
                    foreach (Company c in company)
                    {
                        Console.WriteLine("\nNombre de la empresa: " + c.Name());
                        Console.WriteLine("\nRut de la empresa: " + c.Rut());
                        foreach (Division division in c.Divisions())
                        {
                            Console.WriteLine("\nNombre de la división: " + division.Name());
                            Console.WriteLine("Datos de la persona encargada:");
                            Console.WriteLine("NOMBRE | APELLIDO | RUT | POSICIÓN");
                            division.ChargePerson();
                            if (division.GetType() == typeof(Block))
                            {
                                Console.WriteLine("Datos del personal general " + a + ":");
                                Console.WriteLine("NOMBRE | APELLIDO | RUT | POSICIÓN");
                                division.GeneralStaff();
                                a += 1;
                                if (a > 2)
                                {
                                    a = 1;
                                }
                            }
                        }
                    }                    
                }
                catch
                {
                    Person person = new Person("", "", "", "");
                    Console.WriteLine("No se encontró el archivo solicitado.");
                    Console.WriteLine("\nNombre de la empresa:");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nRut de la empresa (sin punto ni guión):");
                    string rut = Console.ReadLine();
                    //Creando departamento.
                    Console.WriteLine("\nNombre del departamento:");
                    string Dname = Console.ReadLine();
                    ////Creando a la persona encargada.
                    Console.WriteLine("\nNombre de la persona encargada:");
                    string PDname = Console.ReadLine();
                    Console.WriteLine("\nApellido de la persona encargada:");
                    string PDlastname = Console.ReadLine();
                    Console.WriteLine("\nRUT de la persona encargada:");
                    string PDrut = Console.ReadLine();
                    Console.WriteLine("\nPosición de la persona encargada:");
                    string PDposition = Console.ReadLine();
                    Person pD = new Person(PDname, PDlastname, PDrut, PDposition);
                    Department d = new Department(Dname, pD, person);

                    //Creando sección.
                    Console.WriteLine("\nNombre de la sección:");
                    string Sname = Console.ReadLine();
                    ////Creando a la persona encargada.
                    Console.WriteLine("\nNombre de la persona encargada:");
                    string PSname = Console.ReadLine();
                    Console.WriteLine("\nApellido de la persona encargada:");
                    string PSlastname = Console.ReadLine();
                    Console.WriteLine("\nRUT de la persona encargada:");
                    string PSrut = Console.ReadLine();
                    Console.WriteLine("\nPosición de la persona encargada:");
                    string PSposition = Console.ReadLine();
                    Person pS = new Person(PSname, PSlastname, PSrut, PSposition);
                    Section s = new Section(Sname, pS, person);

                    //Creando bloque 1.
                    Console.WriteLine("\nNombre del bloque 1:");
                    string Bname = Console.ReadLine();
                    ////Creando a la persona encargada.
                    Console.WriteLine("\nNombre de la persona encargada:");
                    string PBname = Console.ReadLine();
                    Console.WriteLine("\nApellido de la persona encargada:");
                    string PBlastname = Console.ReadLine();
                    Console.WriteLine("\nRUT de la persona encargada:");
                    string PBrut = Console.ReadLine();
                    Console.WriteLine("\nPosición de la persona encargada:");
                    string PBposition = Console.ReadLine();
                    Person pB = new Person(PBname, PBlastname, PBrut, PBposition);
                    ////Creando a la primera persona del personal general.
                    Console.WriteLine("\nNombre de la persona 1:");
                    string PB1name = Console.ReadLine();
                    Console.WriteLine("\nApellido de la persona 1:");
                    string PB1lastname = Console.ReadLine();
                    Console.WriteLine("\nRUT de la persona 1:");
                    string PB1rut = Console.ReadLine();
                    Console.WriteLine("\nPosición de la persona 1:");
                    string PB1position = Console.ReadLine();
                    Person pB1 = new Person(PB1name, PB1lastname, PB1rut, PB1position);
                    Block b11 = new Block(Bname, pB, pB1);
                    ////Creando a la segunda persona del personal general.
                    Console.WriteLine("\nNombre de la persona 2:");
                    string PB2name = Console.ReadLine();
                    Console.WriteLine("\nApellido de la persona 2:");
                    string PB2lastname = Console.ReadLine();
                    Console.WriteLine("\nRUT de la persona 2:");
                    string PB2rut = Console.ReadLine();
                    Console.WriteLine("\nPosición de la persona 2:");
                    string PB2position = Console.ReadLine();
                    Person pB2 = new Person(PB2name, PB2lastname, PB2rut, PB2position);
                    Block b12 = new Block(Bname, pB, pB2);

                    //Creando bloque 2.
                    Console.WriteLine("\nNombre del bloque 2:");
                    string B3name = Console.ReadLine();
                    ////Creando a la primera persona del personal general.
                    Console.WriteLine("\nNombre de la persona 1:");
                    string PB13name = Console.ReadLine();
                    Console.WriteLine("\nApellido de la persona 1:");
                    string PB13lastname = Console.ReadLine();
                    Console.WriteLine("\nRUT de la persona 1:");
                    string PB13rut = Console.ReadLine();
                    Console.WriteLine("\nPosición de la persona 1:");
                    string PB13position = Console.ReadLine();
                    Person pB13 = new Person(PB13name, PB13lastname, PB13rut, PB13position);
                    Block b3 = new Block(B3name, pB, pB13);
                    ////Creando a la segunda persona del personal general.
                    Console.WriteLine("\nNombre de la persona 2:");
                    string PB23name = Console.ReadLine();
                    Console.WriteLine("\nApellido de la persona 2:");
                    string PB23lastname = Console.ReadLine();
                    Console.WriteLine("\nRUT de la persona 2:");
                    string PB23rut = Console.ReadLine();
                    Console.WriteLine("\nPosición de la persona 2:");
                    string PB23position = Console.ReadLine();
                    Person pB23 = new Person(PB23name, PB23lastname, PB23rut, PB23position);
                    Block b4 = new Block(B3name, pB, pB23);

                    //agrupando las divisiones de la empresa.
                    List<Division> divisions = new List<Division>();
                    divisions.Add(d);
                    divisions.Add(s);
                    divisions.Add(b11);
                    divisions.Add(b12);
                    divisions.Add(b3);
                    divisions.Add(b4);
                    company.Add(new Company(name, rut, divisions));
                    Save(company);
                }
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
        static private List<Company> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Company> company = (List<Company>)formatter.Deserialize(stream);
            stream.Close();
            return company;
        }
    }
}
