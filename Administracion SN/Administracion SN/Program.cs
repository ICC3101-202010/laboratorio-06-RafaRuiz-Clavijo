using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Administracion_SN
{
    class Program
    {
        static void Cargar(List<Empresa> empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            int linea = (int)formatter.Deserialize(stream);

            for (int i = 0; i < linea; i++)
            {
                Empresa data = (Empresa)formatter.Deserialize(stream);
                empresa.Add(data);
            }

            stream.Close();
        }

        static void Guardar(List<Empresa> empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa.Count());
            foreach (Empresa data in empresa)
            {
                formatter.Serialize(stream, data);
            }
            stream.Close();
        }
        static void Main(string[] args)
        {
            List<Empresa> emp = new List<Empresa>();
            Console.WriteLine("SISTEMA DE ADMINISTRACION SUPER NANAS");
            Console.WriteLine("");
            Console.WriteLine("Quiere cargar los datos de las empresas?");
            Console.WriteLine("(1) SI");
            Console.WriteLine("(2) NO");
            int menu = 0;
            Console.WriteLine("Marque la opcion con su numero respectivo");
            while (menu == 0||menu > 2)
            {
                int.TryParse(Console.ReadLine(), out menu);
            }
            switch (menu)
            {
                case 1:
                    try
                    {
                        Cargar(emp);
                        foreach (Empresa data0 in emp) {
                            Console.WriteLine("Datos Empresa");
                            Console.WriteLine("\tNombre: " + data0.Nombre);
                            Console.WriteLine("\tRUT: " + data0.Rut);
                            foreach (Division data in data0.Get_Div())
                            {
                                Console.WriteLine("Division: " + data.Nombre);
                                int i = 1;
                                foreach (Persona p_data in data.Get_Personas())
                                {
                                    Console.WriteLine("\tDatos del encargado " + i);
                                    Console.WriteLine("\t\tNombre Encargado: " + p_data.Name);
                                    Console.WriteLine("\t\tApellido Encargado: " + p_data.Last_name);
                                    Console.WriteLine("\t\tRUT Encargado: " + p_data.Rut);
                                    Console.WriteLine("\t\tEdad Encargado: " + p_data.Edad);
                                    i++;
                                }
                            }
                        }
                        Console.ReadLine();

                    }
                    catch
                    {
                        Console.WriteLine("No se ha podido cargar el archivo, ponga los datos de la empresa forma manual");
                        Console.Write("Nombre de la empresa: ");
                        string name_catch = Console.ReadLine();
                        Console.Write("RUT de la empresa: ");
                        string rut_catch = Console.ReadLine();
                        Empresa emp_catch = new Empresa(name_catch, rut_catch);
                        Departamento dep_catch = new Departamento("Departamento");
                        dep_catch.Crear_Encargado(1);
                        emp_catch.Add_to_Div(dep_catch);
                        Seccion sec_catch = new Seccion("Seccion");
                        sec_catch.Crear_Encargado(1);
                        emp_catch.Add_to_Div(sec_catch);
                        Bloque bloq_catch1 = new Bloque("Bloque 1");
                        bloq_catch1.Crear_Encargado(1);
                        bloq_catch1.Crear_Encargado(2);
                        emp_catch.Add_to_Div(bloq_catch1);
                        Bloque bloq_catch2 = new Bloque("Bloque 2");
                        bloq_catch2.Crear_Encargado(1);
                        bloq_catch2.Crear_Encargado(2);
                        emp_catch.Add_to_Div(bloq_catch2);
                        emp.Add(emp_catch);
                        Guardar(emp);

                    }
                    break;
                case 2:
                    Console.Write("Nombre de la empresa: ");
                    string name= Console.ReadLine();
                    Console.Write("RUT de la empresa: ");
                    string rut = Console.ReadLine();
                    Empresa emp_data = new Empresa(name, rut);
                    Departamento dep = new Departamento("Departamento");
                    dep.Crear_Encargado(1);
                    emp_data.Add_to_Div(dep);
                    Seccion sec = new Seccion("Seccion");
                    sec.Crear_Encargado(1);
                    emp_data.Add_to_Div(sec);
                    Bloque bloq = new Bloque("Bloque 1");
                    bloq.Crear_Encargado(1);
                    bloq.Crear_Encargado(2);
                    emp_data.Add_to_Div(bloq);
                    Bloque bloq2 = new Bloque("Bloque 2");
                    bloq2.Crear_Encargado(1);
                    bloq2.Crear_Encargado(2);
                    emp_data.Add_to_Div(bloq2);
                    emp.Add(emp_data);
                    Guardar(emp);
                    break;
            }
        }
    }
}
