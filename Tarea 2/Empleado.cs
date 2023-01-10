using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;
namespace Tarea_2
{
     class Empleado 
    {
      
        protected string Cedula { get; set; }
        protected string Codigo { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string Email { get; set; }
        protected string Telefono { get; set; }
        protected string Departamento { get; set; }
        protected string Cargo { get; set; }
        protected int Precio { get; set; }
        protected int Horas { get; set; }
        protected int Salario { get; set; }
        protected double SalarioNETO { get; set; }

        static IEmpleado emp;
        public void CrearEmp()
        {
            
            int eleccion = 0;
            do
            {
                Console.WriteLine("Que tipo de empleado desea crear?(Escriba el numero)");
                Console.WriteLine("1-Operativo");
                Console.WriteLine("2-Administrativo");
                if (Gerencial.gerenciall == null)
                {
                    Console.WriteLine("3-Gerencial");
                }
                Console.WriteLine("");
                // aqui va el uso de la interfaz 
                Console.WriteLine("=========================================");
                Console.WriteLine("0- volver al menu anterior");
                eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion == 0)
                {
                    
                }
                else if (eleccion >= 1 && eleccion <= 3)
                {
                    emp = Fabrica.GetEmpleado(eleccion);
                    emp.Crear();
                }
                else 
                {
                    Console.WriteLine("Escriba un numero valido");
                    
                }
                
                Console.Clear();
            } while (eleccion != 0);

        }
        protected string GenerarCode(string depar)
        {
            string code = depar.Substring(0, 3);
            code += Convert.ToString(aleatorio());

            return code;
        }
        protected int aleatorio()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1000, 10000);
            return numero;
        }
      

    }
}
