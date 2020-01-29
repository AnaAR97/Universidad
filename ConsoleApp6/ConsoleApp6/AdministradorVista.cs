using System;
namespace ConsoleApp6
{
    class AdministradorVista
    {
        public void mostrarMenuAdministrador()
        {
            Universidad universidad = new Universidad("SAN SIMON");
            int opciones = 0;
            do
            {
                Console.WriteLine("   <<ADMINISTRADOR>>");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("       1.  -Selecionar Carrera");
                Console.WriteLine("       2.  -Seleccionar Materia");
                Console.WriteLine("       3.  -Seleccionar Docente");
                Console.WriteLine("       4.  -Crear Universitario");
                Console.WriteLine("       5.  -Salir");

                opciones = Int32.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("INGRESE NOMBRE CARRERA: ");
                        Console.WriteLine();
                        Console.WriteLine("         -Sistemas");
                        Console.WriteLine("         -Medicina");
                        Console.WriteLine("         -Contabilidad");
                        Console.WriteLine("         -Fisioterapia");
                        Console.WriteLine("SELECCIONE CARRERA: ");
                        Carrera carrera = new Carrera(Console.ReadLine());
                        universidad.ingreseCarrera(carrera);
                        Console.WriteLine("LA CARRERA ES:");
                        universidad.imprimirCarreras();

                        break;
                    case 2:
                        Console.WriteLine("LAS MATERIAS SON:");
                        Console.WriteLine();
                        Console.WriteLine("          -Programacion I:");
                        Console.WriteLine("          -Calculo I:");
                        Console.WriteLine("          -Sistemas Operativos:");
                        Console.WriteLine("          -Diseño Web:");

                        Console.WriteLine("SELECIONE MATERIA");
                        Materia materia = new Materia(Console.ReadLine());
                        Carrera carrera1 = new Carrera(Console.ReadLine());
                        Console.WriteLine("LA MATERIA SELECCIONADA ES: ");
                        carrera1.imprimirMateria();

                        carrera1.ingreseMateria(materia);
                        carrera1.imprimirMateria();
                        Console.WriteLine();

                        break;
                    case 3:
                        Console.WriteLine("INGRESE NOMBRE DOCENTE: ");
                        Console.WriteLine();
                        Console.WriteLine("          -Bruno Barrios");
                        Console.WriteLine("          -Alvaro Avila");
                        Console.WriteLine("          -Luis Camacho");
                        Console.WriteLine("ASIGNAR DOCENTE: ");
                        Docente docente = new Docente(Console.ReadLine());
                        universidad.ingreseDocente(docente);                                            
                        Console.WriteLine("DOCENTE ASIGNADO ES :");
                        universidad.mostrarDocentes();

                        break;
                    case 4:
                        Console.WriteLine("INGRESE NOMBRE UNIVERSITARIO:  ");
                        Universitario universitario = new Universitario(Console.ReadLine());
                        universidad.ingresarUniversitario(universitario);
                        Console.WriteLine("UNIVERSITARIO REGISTRADO: ");
                        universidad.imprimirUniversitarios();

                        break;
                    case 5:
                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("ESTA OPCION NO EXISTE");

                        break;
                }
            } while (opciones>5);

         }
    }
}

