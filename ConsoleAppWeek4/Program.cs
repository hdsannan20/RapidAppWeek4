using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeek4
{
    public struct Bag
    {
        public int straps, zippers;

        public Bag(int Straps,int Zippers)
        {
            straps = Straps;
            zippers = Zippers;
        }
    }
    class Program
    {
        delegate void VoidDelegate();
        delegate string StringDelegate(string s);
        delegate int IntDelegate(int i);
        static void HouseRunner()
        {
            House house1 = new House();
            House house2 = new House(2);
            House house3 = new House(1, 5.4);

            House house3_1 = new House(rooms: 7, roof: 5);

            // house3_1.Rooms = 12.5;

            Console.WriteLine(house1.Floors);
            Console.WriteLine(house1.Rooms);

            Console.WriteLine("This House has {0} rooms, {1} floors, {2} roofs",
                               house3_1.Rooms, house3_1.Floors, house3_1.Roof);
            Console.WriteLine(house3_1.ToString());
        }

        static void StaticMethodVoid()
        {
            string s = "My String";
            s.ToUpper();
            Console.WriteLine("This is called from our StaticMethodVoid");
            
        }

        static int StaticMethodInt(int myInt)
        {
            return myInt * 2;
        }

        static string StaticMethodString(string myString)
        {
            return myString.ToUpper();
        }
        static void SecondVoidStaticMethod()
        {
            Console.WriteLine("second output");

        }
        static void StructExample()
        {
            Bag b;

            Bag c = new Bag(4, 7);
            b.straps = 2;
            b.zippers = 3;

            Console.WriteLine("The Bag has {0} straps, {1} zippers: ", b.straps, b.zippers);
            Console.WriteLine("The Bag has {0} straps, {1} zippers: ", c.straps, c.zippers);
        }
        // create a static method that:
        // takes an Integer
        // return the double Value
         
            /*
             * create a static method that:
             * takes a string
             * returns that string in uppercase
             */

        static void Main(string[] args)
        {
            VoidDelegate vd = new VoidDelegate(StaticMethodVoid);
            IntDelegate id = new IntDelegate(StaticMethodInt);
            StringDelegate sd = new StringDelegate(StaticMethodString);

            VoidDelegate vd2 = new VoidDelegate(SecondVoidStaticMethod);

            vd();
            vd2();
            Console.WriteLine("The value of {0} double is {1}", 5, id(5));
            string text = "My string text";
            Console.WriteLine("{0} in uppercase is {1}", text, sd(text));

            foreach (char c in text)
            {
                Console.WriteLine("{0} in ASCII2 is {1}", c, (int)c);
            }
            Console.ReadKey();
        }
    }
}
