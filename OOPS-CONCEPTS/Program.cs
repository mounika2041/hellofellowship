using OOPS_CONCEPTS.ClassObject;
using OOPS_CONCEPTS.polymorphism.MethodOverloding;
using OOPS_CONCEPTS.polymorphism.MethodOverRiding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO OOPS CONCEPTS");
            Console.WriteLine("1:class and object\n2:inheitance\n3: polymorphism .methodoverloding\n4:polymorphism.methodoverriding");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fruit apple = new Fruit("apple", "red");
                    apple.FruitDetails();
                    Fruit orange = new Fruit("orange", "yellow");
                    orange.FruitDetails();
                    break;
                case 2:
                    Inheritance.Car car = new Inheritance.Car();
                    car.Brand = "BMW";
                    car.start();
                    break;
                case 3:
                    Addition addition = new Addition();
                    addition.Add(10, 20, 30);
                    break;
                case 4:
                    PartTimeEmployee partTime = new PartTimeEmployee();
                    partTime.empName = "Mouni";
                    partTime.calculatesalary();
                break;
                default:
                    Console.WriteLine("please select a number within range");
                    break;
            }
            Console.ReadLine();
        }
    }
}
