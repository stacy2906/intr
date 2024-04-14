using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Создание объекта DerivedClass и вызов методов
                DerivedClass dClass = new DerivedClass();
                dClass.Method1();
                dClass.Method2();
                dClass.Method3();
                Console.ReadKey();
            
        }
    }
}
