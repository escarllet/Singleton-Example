using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Operativo : Empleado, IEmpleado
    {
        public static List<Operativo> empOpe = new List<Operativo>();
        public void Cobrar()
        {
            double salarioN;
            for (int i = 0; i < empOpe.Count; i++)
            {
                salarioN = Convert.ToInt64(empOpe[i].Salario) * 0.10f;
                empOpe[i].SalarioNETO = salarioN + Convert.ToInt64(empOpe[i].Salario);
                Console.WriteLine("El empleado codigo: " + empOpe[i].Codigo + "Ha cobrado " + salarioN);
                Console.WriteLine("");
                Console.WriteLine("=============================================");
                Console.WriteLine("");
            }
        }
        public void Crear()
        {
            int id;
            id = empOpe.Count;
            empOpe.Add(new Operativo());
 
            empOpe[id].Cargo = "Operativo";

            Console.WriteLine("Ingrese los siguientes datos:");
            Console.WriteLine("Departamento del Empleado");
            empOpe[id].Departamento = Console.ReadLine();
            empOpe[id].Codigo = GenerarCode(empOpe[id].Departamento);
            Console.Clear();
            Console.WriteLine("Nombre del Empleado (solo nombre)");
            empOpe[id].Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Apellido del Empleado");
            empOpe[id].Apellido = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Cedula del Empleado (con guiones)");
            empOpe[id].Cedula = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Email del Empleado");
            empOpe[id].Email = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Telefono del Empleado(con guiones)");
            empOpe[id].Telefono = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Precio por hora: ");
            empOpe[id].Precio = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Cantidad de horas trabajadas: ");
            empOpe[id].Horas = Convert.ToInt32(Console.ReadLine());
            empOpe[id].Salario = empOpe[id].Precio * empOpe[id].Horas;
            Console.Clear();
            Console.WriteLine("El empleado se ha ingresado de forma exitosa!");
            Console.WriteLine("El codigo de empleado es:" + empOpe[id].Codigo);
            Console.WriteLine("");
            Console.WriteLine("================================================");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public  void MostrarEmp()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("");
            Console.WriteLine("                   OPERATIVO");
            Console.WriteLine("");
            Console.WriteLine("==============================================");
            Console.WriteLine("");
            for (int i = 0; i < empOpe.Count; i++)
            {
                Console.WriteLine("Codigo: " + empOpe[i].Codigo);
                Console.WriteLine("Nombre: " + empOpe[i].Nombre);
                Console.WriteLine("Apellido: " + empOpe[i].Apellido);
                Console.WriteLine("Email: " + empOpe[i].Email);
                Console.WriteLine("Telefono: " + empOpe[i].Telefono);
                Console.WriteLine("Cargo: " + empOpe[i].Cargo);
                Console.WriteLine("Departamento: " + empOpe[i].Departamento);
                Console.WriteLine("Precio por hora: " + empOpe[i].Precio);
                Console.WriteLine("Horas trabajadas: " + empOpe[i].Horas);
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("");
            }
        }
        public void Factura()
        {

            for (int i = 0; i < empOpe.Count; i++)
            {
                Console.WriteLine("Codigo: " + empOpe[i].Codigo);
                Console.WriteLine("Nombre: " + empOpe[i].Nombre);
                Console.WriteLine("Apellido: " + empOpe[i].Apellido);
                Console.WriteLine("Cargo: " + empOpe[i].Cargo);                           
                Console.WriteLine("Precio por hora: " + empOpe[i].Precio);
                Console.WriteLine("Horas trabajadas: " + empOpe[i].Horas);
                Console.WriteLine("Salario Neto (Bono aplicado): " + empOpe[i].SalarioNETO);
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("");
            }
        }
    }
}
