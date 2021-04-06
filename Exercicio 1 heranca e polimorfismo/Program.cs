using Exercicio_1_heranca_e_polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_heranca_e_polimorfismo
{
    class Program
    {
        static List<Employee> list = new List<Employee>();
        static void Main(string[] args)
        {            
            Console.Write("Entre com o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do empregado #{i}:");
                Console.Write("Terceirizado (Y/N)? ");
                char respT = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (respT == 'y' || respT == 'Y')
                {
                    Console.Write("Carga adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
