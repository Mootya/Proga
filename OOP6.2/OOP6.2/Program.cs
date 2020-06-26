using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class classone = new Class();
            classone.Display();
            Class classtwo = new Class("143476578464");
            classtwo.Display();
            Class classthree = new Class("658");
            classthree.Display();
            Console.ReadKey();
        }

    }
}
class Class
{
    private string Metod;

    public Class()
    {
        Metod = "Пуcто";
    }
    public Class(string Line)
    {
        if (Line.Length > 10)
            this.Metod = "Очень длинная строка";
        else
            this.Metod = Line;
    }
    public void Display()
    {
        Console.WriteLine(Metod);
    }
}
