using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeCreate
{
    public class Create
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Would you like to: ");
            Console.WriteLine("(1) Create a Square");
            Console.WriteLine("(2) Create a Rectangle");
            Console.Write("Enter selection: ");
            var choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                List<int> Square = new List<int>();

                Console.Write("Please enter the Side Length of your square: ");
                var sidelength = int.Parse(Console.ReadLine());
                var perimeter = sidelength + sidelength + sidelength + sidelength;

                Square.Add(perimeter);




                foreach (int i in Square)
                    Console.WriteLine(i);


            }

            else if (choice == 2)
            {

                List<int> Rectangle = new List<int>();
                Console.WriteLine("Rectangle");
            }
            else
            {
                Console.WriteLine("invalid option");
            }



            Console.ReadKey();

        }
    }
}
