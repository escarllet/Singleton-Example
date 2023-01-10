using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Program 
    {
   
        static void Main(string[] args)
        {
            int eleccion = 0;
            Empleado emp = new Empleado();
            IEmpleado empa;
            do
            {
                Console.WriteLine(" _______  ___   _______  __    _  __   __  _______  __    _  ___   ______   _______ / _______ ");
                Console.WriteLine("|  __   ||   | |       ||  |  | ||  | |  ||       ||  |  | ||   | |      | |       | |   _   |");
                Console.WriteLine("| |__|  ||   | |    ___||   |_| ||  |_|  ||    ___||   |_| ||   | |  _    ||   _   | |  |_|  |");
                Console.WriteLine("|       ||   | |   |___ |       ||       ||   |___ |       ||   | | | |   ||  | |  | |       |");
                Console.WriteLine("|  __  | |   | |    ___||  _    ||       ||    ___||  _    ||   | | |_|   ||  |_|  | |       |");
                Console.WriteLine("| |__|  ||   | |   |___ | | |   | |     | |   |___ | | |   ||   | |       ||       | |   _   |");
                Console.WriteLine("|_______||___| |_______||_|  |__|  |___|  |_______||_|  |__||___| |______| |_______| |__| |__|");
                Console.WriteLine("");
                Console.WriteLine("Que desea hacer?(Escriba el numero)");
                Console.WriteLine("1-Crear empleado");
                Console.WriteLine("2-Ver empleados");
                Console.WriteLine("3-Cobrar");
                Console.WriteLine("4-Recibo de pago");
                Console.WriteLine("");
                Console.WriteLine("===========================================");
                Console.WriteLine("0-Salir");
                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (eleccion)
                {
                    case 0:                     
                        break;
                    case 1:                     
                        emp.CrearEmp();
                        break;
                    case 2:
                        empa = Fabrica.GetEmpleado(3);
                        empa.MostrarEmp();
                        empa = Fabrica.GetEmpleado(2);
                        empa.MostrarEmp();
                        empa = Fabrica.GetEmpleado(1);
                        empa.MostrarEmp();

                        Console.WriteLine("=========================================");
                        Console.WriteLine("Presione cualquier tecla para continuar");                      
                        Console.ReadLine();
                        
                        break;
                    case 3:
                        empa = Fabrica.GetEmpleado(3);
                        empa.Cobrar();
                        empa = Fabrica.GetEmpleado(2);
                        empa.Cobrar();
                        empa = Fabrica.GetEmpleado(1);
                        empa.Cobrar();

                        Console.WriteLine("=========================================");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        empa = Fabrica.GetEmpleado(3);
                        empa.Factura();
                        empa = Fabrica.GetEmpleado(2);
                        empa.Factura();
                        empa = Fabrica.GetEmpleado(1);
                        empa.Factura();
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Escoja un numero valido");
                        break;
                }
                Console.Clear();
            } while (eleccion !=0) ;

            Console.WriteLine("=========================================");
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadLine();

        }

    }
    
}
