using System;
namespace ConsoleApp6
{
    class UniversitarioVista
    {
        public void mostrarMenuUniversitario()
        {
            
                Universidad universidad = new Universidad("SAN SIMON");
                int opciones = 0;
                do
                {
                    Console.WriteLine("    <<UNIVERSIATRIO>>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("       1.  -Tomar Materia");
                    Console.WriteLine("       2.  -Ver Horario");
                    Console.WriteLine("       3.  -Abandonar Materia");
                  

                    opciones = Int32.Parse(Console.ReadLine());
                    switch (opciones)
                    {
                        case 1:
                            Console.WriteLine("TOMAR MATERIA: ");
                            Console.WriteLine();
                            Console.WriteLine("          -Programacion I:");
                            Console.WriteLine("          -Calculo I:");
                            Console.WriteLine("          -Sistemas Operativos:");
                            Console.WriteLine("          -Diseño Web:");
                            Console.WriteLine("ASIGNAR MATERIA");
                            Materia materia = new Materia(Console.ReadLine());                     
                            Console.WriteLine("LA MATERIA ASIGNADA ES:");
                            Carrera carrera = new Carrera(Console.ReadLine());
                            carrera.ingreseMateria(materia);
                            carrera.imprimirMateria();

                        break;
                        case 2:
                        
                            Console.WriteLine("HORARIOS");
                            Console.WriteLine();
                            Console.WriteLine("       -Mañana");
                            Console.WriteLine("       -Tarde");
                            Console.WriteLine("       -Noche");

                            Console.WriteLine("HORARIO SELECCIONADO: ");
                            Materia materia1 = new Materia(Console.ReadLine());
                                                

                        break;
                        case 3:
                            Console.WriteLine("ABANDONAR MATERIAS:");
                            Console.WriteLine();
                            Console.WriteLine("          -Programacion I");
                            Console.WriteLine("          -Calculo I");
                            Console.WriteLine("          -Sistemas Operativos");
                            Console.WriteLine("          -Diseño Web");
                            Console.WriteLine("MATERIA ABANDONADA: ");
                            Materia materia4 = new Materia(Console.ReadLine());
                        Console.WriteLine("MATERIA ABANDONADA: ");
                        Carrera carrera1 = new Carrera(Console.ReadLine());
                        carrera1.ingreseMateria(materia4);
                        carrera1.imprimirMateria();
                           

                        break;
                        default:
                            Console.WriteLine("ESTA OPCION NO EXISTE");

                            break;
                    }
                } while (opciones > 3);

            
        }
    }
}
