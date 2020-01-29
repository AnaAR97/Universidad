using System;
namespace ConsoleApp6
{
    class DocenteVista
    {
        public void mostrarMenuDocente()
        {
            Universidad universidad = new Universidad("SAN SIMON");
            int opciones = 0;
            do
            {
                Console.WriteLine("    <<DOCENTE>>");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("       1.  -Seleccionar Materia");
                Console.WriteLine("       2.  -Deselecciona Materia");
                Console.WriteLine("       3.  -Horario");


                opciones = Int32.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        
                            Console.WriteLine("LAS MATERIAS SON:");

                            Console.WriteLine("          -Programacion I");
                            Console.WriteLine("          -Calculo I");
                            Console.WriteLine("          -Sistemas Operativos");
                            Console.WriteLine("          -Diseño Web");
   
                        Console.WriteLine("SELECIONE MATERIA");
                        Materia materia = new Materia(Console.ReadLine());
                        Carrera carrera = new Carrera(Console.ReadLine());
                        Console.WriteLine("LA MATERIA SELECCIONADA ES: ");
                        carrera.imprimirMateria();

                        carrera.ingreseMateria(materia);
                        carrera.imprimirMateria();
                        Console.WriteLine();


                        break;
                    case 2:
                        Console.WriteLine("LAS MATERIAS SON:");
                      
                        Console.WriteLine("          -Calculo I");
                        Console.WriteLine("          -Sistemas Operativos");
                        Console.WriteLine("          -Diseño Web");
                        Console.WriteLine();                      
                        Console.WriteLine("DESELECCIONAR MATERIA");
                        Materia materia4 = new Materia(Console.ReadLine());
                        Carrera carrera3 = new Carrera(Console.ReadLine());
                       
                        string quitarMateria = Console.ReadLine();
                        carrera3.eliminarMateria(quitarMateria);
                        Console.WriteLine();

                        Console.WriteLine("MATERIA DESELECCIONADA");
                        carrera3.ingreseMateria(materia4);
                        carrera3.imprimirMateria();
                        Console.ReadLine();
                       
                        break;
                    case 3:
                        Console.WriteLine("HORARIOS");
                        Console.WriteLine();
                        Console.WriteLine("       -Mañana");
                        Console.WriteLine("       -Tarde");
                        Console.WriteLine("       -Noche");

                        Console.WriteLine("SELECIONE HORARIO: ");
                        Materia materia1 = new Materia(Console.ReadLine());
                        

                        break;
                    default:
                        Console.WriteLine("ESTA OPCION NO EXISTE");

                        break;
                }
            } while (opciones > 3);

        }
    }

}
   
