using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Gerencial : Empleado, IEmpleado 
    {
        public static Gerencial gerenciall;
        public static List<Gerencial> empGer = new List<Gerencial>();
        private Gerencial()
        {

        }

        public static Gerencial singleton()
        {
            if (gerenciall == null)
            {
                gerenciall = new Gerencial();
            }

            return gerenciall;
        }
        public void Cobrar()
        {
            double salarioN;
            for (int i = 0; i < empGer.Count; i++)
            {
                salarioN = Convert.ToInt64(empGer[i].Salario) * 0.50f;
                empGer[i].SalarioNETO = salarioN + Convert.ToInt64(empGer[i].Salario);
                Console.WriteLine("El empleado codigo: " + empGer[i].Codigo + "Ha cobrado " + salarioN);
                Console.WriteLine("");
                Console.WriteLine("=============================================");
                Console.WriteLine("");
            }
        }
        public void Crear()
        {
            int id = empGer.Count;
            empGer.Add(new Gerencial());
            
            empGer[id].Cargo = "Gerencial";

            Console.WriteLine("Ingrese los siguientes datos:");
            Console.WriteLine("Departamento del Empleado");
            empGer[id].Departamento = Console.ReadLine();
            empGer[id].Codigo = GenerarCode(empGer[id].Departamento);
            Console.Clear();
            Console.WriteLine("Nombre del Empleado (solo nombre)");
            empGer[id].Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Apellido del Empleado");
            empGer[id].Apellido = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Cedula del Empleado (con guiones)");
            empGer[id].Cedula = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Email del Empleado");
            empGer[id].Email = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Telefono del Empleado(con guiones)");
            empGer[id].Telefono = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Precio por hora: ");
            empGer[id].Precio = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Cantidad de horas trabajadas: ");
            empGer[id].Horas = Convert.ToInt32(Console.ReadLine());
            empGer[id].Salario = empGer[id].Precio * empGer[id].Horas;
            Console.Clear();
            Console.WriteLine("El empleado se ha ingresado de forma exitosa!");
            Console.WriteLine("El codigo de empleado es:" + empGer[id].Codigo);
            Console.WriteLine("");
            Console.WriteLine("================================================");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public  void MostrarEmp()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("");
            Console.WriteLine("                 GERENCIAL");
            Console.WriteLine("");
            Console.WriteLine("==============================================");
            Console.WriteLine("");


            for (int i = 0; i < empGer.Count ; i++)
            {

                Console.WriteLine("Codigo: " + empGer[i].Codigo);
                Console.WriteLine("Nombre: " + empGer[i].Nombre);
                Console.WriteLine("Apellido: " + empGer[i].Apellido);
                Console.WriteLine("Email: " + empGer[i].Email);
                Console.WriteLine("Telefono: " + empGer[i].Telefono);
                Console.WriteLine("Cargo: " + empGer[i].Cargo);
                Console.WriteLine("Departamento: " + empGer[i].Departamento);
                Console.WriteLine("Precio por hora: " + empGer[i].Precio);
                Console.WriteLine("Horas trabajadas: " + empGer[i].Horas);


            }
        }
        public void Factura()
        {

            for (int i = 0; i < empGer.Count; i++)
            {
                Console.WriteLine("Codigo: " + empGer[i].Codigo);
                Console.WriteLine("Nombre: " + empGer[i].Nombre);
                Console.WriteLine("Apellido: " + empGer[i].Apellido);
                Console.WriteLine("Cargo: " + empGer[i].Cargo);
                Console.WriteLine("Precio por hora: " + empGer[i].Precio);
                Console.WriteLine("Horas trabajadas: " + empGer[i].Horas);
                Console.WriteLine("Salario Neto (Bono aplicado): " + empGer[i].SalarioNETO);
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("");
            }
        }
    }
}
