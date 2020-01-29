using System;
namespace ConsoleApp6
{
    class MenuSistema
    {
        public void menuPrincipal()
        {
            int opcion=0;
            do
            {
                while (true)
                {
                   
                    Console.WriteLine("              <<MENU DEL SISTEMA>>");
                    Console.WriteLine();
                    Console.WriteLine("ROLES: ");
                    Console.WriteLine();
                    Console.WriteLine("       1.  -Administrador");
                    Console.WriteLine("       2.  -Universitario");
                    Console.WriteLine("       3.  -Docente");

                    opcion = Int32.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("MENU ADMINISTRADOR");
                            AdministradorVista administradorVista = new AdministradorVista();
                            administradorVista.mostrarMenuAdministrador();

                            break;
                        case 2:
                            Console.WriteLine("MENU UNIVERSITARIO");
                            UniversitarioVista universitarioVista = new UniversitarioVista();
                            universitarioVista.mostrarMenuUniversitario();

                            break;
                        case 3:
                            Console.WriteLine("MENU DOCENTE");
                            DocenteVista docenteVista = new DocenteVista();
                            docenteVista.mostrarMenuDocente();

                            break;
                        default:
                            Console.WriteLine("ESTA OPCION NO EXISTE");
                            break;
                    }
                }


            } while (opcion <=3);
            Console.ReadKey();
        }
       
    }
}
