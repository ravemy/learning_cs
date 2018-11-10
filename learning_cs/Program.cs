using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc2
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicConcepts();
            //ConditionalsAndLoops();
            Methods();
        }

        static void Methods()
        {
            int a = 11;
            int e = 4;
            int b = C(e, 7);


            int t = C(6, a);

            Console.WriteLine(b);

            // =======

            int C(int h, int j)
            {
                return h*h +j;
            }

            // Optional Arguments

            int Pow(int x, int y = 2)
            {
                int result = 1;
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }

                return result;
            }

            int d=Pow(4);

            // ref


            int a1 = 7;
            int a2 = 9;

            Console.WriteLine($"Before: a1={a1}, a2={a2}");

            Swap(ref a1, ref a2);

            Console.WriteLine($"After:  a1={a1}, a2={a2}");
            
            void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            // out

            Console.Write("Nummer eingeben: ");
            string userInputStr = Console.ReadLine();

            // kann exeption hervorrufen
            //int value = int.Parse(userInputStr);

            int iValue;
            double dValue;
            if (int.TryParse(userInputStr, out iValue))
            {
                DoStuff(iValue);
            }
            else if (double.TryParse(userInputStr, out dValue))
            {
                DoStuff(dValue);
            }
            else
            {
                Console.WriteLine("Die eingegebene Zahl ist kein Integer");
            }

        }

        static void DoStuff(int i)
        {
            Console.WriteLine($"Hälfte der eingegebenen Zahl: {i / 2}");
        }

        static void DoStuff(double d)
        {
            Console.WriteLine($"Doppelte der eingegebenen Zahl: {d * 2}");
        }

        static void ConditionalsAndLoops()
        {
            // 1. The if-else Statement
            int g = 3, h = 5;

            if (g+h>4)
            {
                Console.WriteLine("yes, it's true");
            }
            // == != >= <=

            int r = 3, e = 9;

            if (r==e)
            {
                Console.WriteLine("yay");   
            }
            else
            {
                Console.WriteLine("oh no");
            }

            int age = 17;

            if (age>14)
            {
                if (age>=18)
                {
                    Console.WriteLine("adult");
                }
                else
                {
                    Console.WriteLine("teenager");
                }
            }
            else
            {
                if (age<0)
                {
                    Console.WriteLine("wrong");
                }
                else
                {
                    Console.WriteLine("child");
                }
            }

            if (age>=18)
            {
                Console.WriteLine("adult");
            }
            else if (age>14)
            {
                Console.WriteLine("teenager");
            }
            else if (age>=0)
            {
                Console.WriteLine("child");
            }
            else
            {
                Console.WriteLine("none");
            }

            // 2. The switch Statement

            string name = "felix";
            switch (name)
            {
                case "felix":
                    Console.WriteLine("Hello Felix");
                    break;
                case "lisa":
                    Console.WriteLine("Hello Lisa");
                    break;
                default:
                    Console.WriteLine("unknown name");
                    break;
            }

            // 3. The while Loop

            int number = 1;
            while (number < 5)   //führt sachen in der geschweiften klammer so lange aus solange das statement true ist 
            {
                Console.WriteLine(number);
                number++;
            }

            // more complex usecase
            //Console.WriteLine("Type something:");
            //string input = Console.ReadLine();
            //while (!input.StartsWith("Hello"))
            //{
            //    Console.WriteLine("Try again:");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("You did it!");

            // while loop

            int num = 0;
            while (num++<6)
            {
                Console.WriteLine(num);
            }

            // 4. The for loop

            //for (init; condition; increment)
            //{
            //    statement(s);
            //}

            for (int x = 10; x < 15; x++)
            {
                Console.WriteLine($"Value of x: {x}");
            }

            int y = 10;
            while(y < 15)
            {
                Console.WriteLine($"Value of x: {y}");
                y++;
            }

            // 5. The do-while loop
            // wird mindestens einmal ausgeführt

            int z = 5;
            do
            {
                Console.WriteLine(z);
                z++;
            } while (z<8);

            // 6. break and continue

            //prints 0 1 2 3
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);
            }

            //prints 0 1 2 3 5 6 7 8 9
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

            // 7. Logical operators

            // x && y    x and y
            // x || y    x or y
            // !x        not x

            int alter = 42;
            double money = 540;
            int score = 5;
            if (alter > 18 && money > 100 && score == 5)
            {
                Console.WriteLine("Welcome");
            }

            int b = 8;
            if (!(b >= 16))
            {
                Console.Write("Your age is less than 16");
            }

            // Outputs "Your age is less than 16"

            // 8. The Conditional Operator

            age = 42;
            string msg;
            msg = (age >= 18) ? "Welcome" : "Sorry";
            Console.WriteLine(msg);

            // 9. Simple Calculator

            do
            {
                Console.Write("x = ");
                string str = Console.ReadLine();
                if (str == "exit")
                {
                    break;
                }

                int x = Convert.ToInt32(str);


                Console.Write("y = ");
                int p = Convert.ToInt32(Console.ReadLine());

                int sum = x + p;
                Console.WriteLine($"Result: {sum}");
            }
            while (true);
        }


        static void BasicConcepts()
        {
            Console.WriteLine("Hallo Felix");

            // this is my age
            short myAge = 23;
            Console.WriteLine(myAge);
            Console.WriteLine($"My Age is {myAge}");

            double a = 5.012345, b = 7;
            Console.WriteLine("a={0}, b={1}", a, b);

            string myName;
            Console.WriteLine("What is your name?");
            myName = Console.ReadLine();
            Console.WriteLine($"Hello {myName}");

            Console.WriteLine("How old are you?");
            int yourAge = Convert.ToInt32(Console.ReadLine()); // liest string von der kommandozeile und wandelt ihn in int um
            Console.WriteLine($"You are {yourAge} years old");

            /* blablabla
             * aha
             */

            var h = 5;


            const double u = 6.22;
            //u = 5; //error

            int omg = 9, wtf = 2;
            Console.WriteLine(omg % wtf);   //modulo (rest)
            Console.WriteLine(omg / wtf);   // ganzahldivision (rest wird ignoriert)
            Console.WriteLine((double)omg / wtf);  // division mit komma

            int simba = 4 + 5 * 6;
            Console.WriteLine(simba); //rechen reihenfolge regeln

            int w = 9;
            w += 2;       // erhöht w um 2      (w = w + 2;)
            w++;          // erhöht w um 1      (w = w + 1;)

            int l = 16;
            int k = l++;  //k ist 16        (var l_old = l; l = l + 1; k = l_old)
                          //l ist 17        
            int d = ++l;  //d ist 18        (l = l + 1; d = l;)
                          //l ist 18
        }
    }
}
