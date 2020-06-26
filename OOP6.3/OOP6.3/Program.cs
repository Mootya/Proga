using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tri trone = new Tri(3, 5, 7);

            trone.Display();

            Tri trtwo = new Tri(1, 10, 20);

            trtwo.Display();

            Tri tr3 = new Tri(1, 2, 3);

            tr3.Display();

            Console.ReadKey();
        }
    }
}
class Tri

{

    private bool Trig;

    private double a;

    private double b;

    private double g;



    public Tri(int l1, int l2, int l3)

    {

        double A = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2))) * (180 / Math.PI);

        double B = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3))) * (180 / Math.PI);

        double G = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3))) * (180 / Math.PI);



        if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))

        {

            Trig = true;



            a = A;

            b = B;

            g = G;

        }

        else

        {

            Trig = false;

        }



    }



    public void Display()

    {

        if (Trig == true)

        {

            Console.WriteLine($"\nУглы треугольника \n\n" + $"A : {a.ToString("##.#")}" + $"\nB : {b.ToString("##.#")}" + $"\nG : {g.ToString("##.#")}");

        }

        else

            Console.WriteLine("\nТреугольник не построить");

    }

}