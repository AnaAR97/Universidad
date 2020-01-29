using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MenuSistema menuSistema = new MenuSistema();
            menuSistema.menuPrincipal();


            /* Console.WriteLine("                     <UNIVERCIDAD> ");

             Universidad universidad = new Universidad("-UNICEN");

             Console.WriteLine("LA UNIVERSIDAD  ES " + universidad.getnombreUniversidad());
             Console.WriteLine();
             Console.WriteLine();
             int cont = 0;
             do
             {
                 Console.WriteLine("INGRESE NOMBRE DEL UNIVERSITARIO");
                 string nombreUniversitario = Console.ReadLine();
                 Universitario univercitario1 = new Universitario(nombreUniversitario);
                 Console.WriteLine("SU CODIGO DEL UNIVERSITARIO ES " + univercitario1.getCodigo());
                 universidad.ingresarUniversitario(univercitario1);
                 cont++;
             } while (cont < 5);

             //Nombres universitarios
             Console.WriteLine("LOS UNIVERSITARIOS SON");
             universidad.imprimirUniversitarios();

             Console.WriteLine("INGRESE NOMBRE QUE DESEA ELIMINAR");
             string nombreEliminar = Console.ReadLine();
             universidad.eliminarUniversitario(nombreEliminar);
             Console.WriteLine();
             Console.WriteLine("LOS UNIVERSITARIOS SON");
             universidad.imprimirUniversitarios();
             Console.WriteLine();

             Materia programacio1 = new Materia("-PROGRAMACION 1");
             Console.WriteLine();
             Console.WriteLine("LA MATERIA  ES " + programacio1.getnombreMateria());
             Console.WriteLine();
             Carrera sistemas = new Carrera("-SISTEMAS");
             Carrera sistemas2 = new Carrera("-MEDICINA");
             Carrera sistemas3 = new Carrera("-ADMINISTRACION");a
             universidad.ingreseCarrera(sistemas);
             universidad.ingreseCarrera(sistemas2);
             universidad.ingreseCarrera(sistemas3);
             //sistemas.ingreseMateria(programacio1);
             //Console.WriteLine("LA CARRERA  ES " + sistemas.getnombreCarrera());
             Console.WriteLine();
             universidad.ingreseCarrera(sistemas);
             Console.WriteLine("LAS CARRERAS SON");
             Console.WriteLine();
             universidad.imprimirCarreras();


             Console.WriteLine("INGRESE CARRERA A ELIMINAR: ");
             string carreraEliminar = Console.ReadLine();
             universidad.eliminarCarrera(carreraEliminar);
             Console.WriteLine();
             Console.WriteLine("LAS CARRERAS SON ");
             universidad.imprimirCarrera();


             Console.WriteLine("A QUE CARRERA DESEA REGISTRASE :");
             string registrarCarrera = Console.ReadLine();
             Universidad universidad2 = new Universidad("");
             Console.WriteLine();

             Console.WriteLine("INGRESE NOMBRE DEL UNIVERSITARIO");
             string nombreUniversitario1 = Console.ReadLine();
             universidad.registrarEstudiante(registrarCarrera, nombreUniversitario1);

             Universidad getNombredDocente = new Universidad("-BRUNO");
             Console.WriteLine("EL DOCENTE ES " + getNombredDocente.getnombreUniversidad());
             Console.WriteLine();
             Console.WriteLine("EL UNIVERSITARIO REGISTRADO ES: " + nombreUniversitario1 + "\n SU CARRERA ES: " + registrarCarrera);
             string registrarEstudiante = Console.ReadLine();


             Console.ReadKey();
         }*/
        }

    }
}
    