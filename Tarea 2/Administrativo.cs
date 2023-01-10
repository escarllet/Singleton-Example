using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2
{
    class Administrativo : Empleado, IEmpleado
    {
        public static List<Administrativo> empAdm = new List<Administrativo>();
        public void Cobrar()
        {
            double salarioN;
            for (int i = 0; i < empAdm.Count; i++)
            {
                salarioN = Convert.ToInt64(empAdm[i].Salario) * 0.25f;
                empAdm[i].SalarioNETO = salarioN + Convert.ToInt64(empAdm[i].Salario);
                Console.WriteLine("El empleado codigo: " + empAdm[i].Codigo + "Ha cobrado " + salarioN);
                Console.WriteLine("");
                Console.WriteLine("=============================================");
                Console.WriteLine("");
            }
        }
        public void Crear()
        {
            int id = empAdm.Count;

            empAdm.Add(new Administrativo());
            
            empAdm[id].Cargo = "Administrativo";

            Console.WriteLine("Ingrese los siguientes datos:");
            Console.WriteLine("Departamento del Empleado");
            empAdm[id].Departamento = Console.ReadLine();
            empAdm[id].Codigo = GenerarCode(empAdm[id].Departamento);
            Console.Clear();
            Console.WriteLine("Nombre del Empleado (solo nombre)");
            empAdm[id].Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Apellido del Empleado");
            empAdm[id].Apellido = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Cedula del Empleado (con guiones)");
            empAdm[id].Cedula = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Email del Empleado");
            empAdm[id].Email = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Telefono del Empleado(con guiones)");
            empAdm[id].Telefono = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Precio por hora: ");
            empAdm[id].Precio = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Cantidad de horas trabajadas: ");
            empAdm[id].Horas = Convert.ToInt32(Console.ReadLine());
            empAdm[id].Salario = empAdm[id].Precio * empAdm[id].Horas;
            Console.Clear();
            Console.WriteLine("El empleado se ha ingresado de forma exitosa!");
            Console.WriteLine("El codigo de empleado es:" + empAdm[id].Codigo);
            Console.WriteLine("");
            Console.WriteLine("================================================");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public  void MostrarEmp()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("");
            Console.WriteLine("                   ADMINISTRATIVO");
            Console.WriteLine("");
            Console.WriteLine("==============================================");
            Console.WriteLine("");
            for (int i = 0; i < empAdm.Count; i++)
            {
                Console.WriteLine("Codigo: " + empAdm[i].Codigo);
                Console.WriteLine("Nombre: " + empAdm[i].Nombre);
                Console.WriteLine("Apellido: " + empAdm[i].Apellido);
                Console.WriteLine("Email: " + empAdm[i].Email);
                Console.WriteLine("Telefono: " + empAdm[i].Telefono);
                Console.WriteLine("Cargo: " + empAdm[i].Cargo);
                Console.WriteLine("Departamento: " + empAdm[i].Departamento);
                Console.WriteLine("Precio por hora: " + empAdm[i].Precio);
                Console.WriteLine("Horas trabajadas: " + empAdm[i].Horas);
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("");
            }
        }
        public void Factura()
        {

            for (int i = 0; i < empAdm.Count; i++)
            {
                Console.WriteLine("Codigo: " + empAdm[i].Codigo);
                Console.WriteLine("Nombre: " + empAdm[i].Nombre);
                Console.WriteLine("Apellido: " + empAdm[i].Apellido);
                Console.WriteLine("Cargo: " + empAdm[i].Cargo);
                Console.WriteLine("Precio por hora: " + empAdm[i].Precio);
                Console.WriteLine("Horas trabajadas: " + empAdm[i].Horas);
                Console.WriteLine("Salario Neto (Bono aplicado): " + empAdm[i].SalarioNETO);
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("");
            }
        }
    }
}
