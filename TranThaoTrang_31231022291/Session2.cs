namespace TranThaoTrang_31231022291
{
    internal class Session2
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            Question_07();
            //Question_08();
            //Question_09();
            //Question_10();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }

        public static void Question_01()
        {
            Console.WriteLine("Enter a number a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b= ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} + {b} = {product}");
        }
        
        public static void Question_02()
        {
            Console.WriteLine("Enter a number a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b= ");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");

        }

        public static void Question_03()
        {
            Console.WriteLine("Enter a floating point number a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a floating point number b = ");
            float b = float.Parse(Console.ReadLine());
            float product = a * b;

            Console.WriteLine($"Product: {product}");
        }

        public static void Question_04()
        {
            Console.WriteLine("Enter the value in feet = ");
            double feet = double.Parse(Console.ReadLine());
            double meters = feet * 0.3048;

            Console.WriteLine($"{feet} feet is equal to {meters} meters.");
        }

        public static void Question_05()
        {
            Console.Write("Enter C => F, Enter F => C: ");
            string donvi = Console.ReadLine();
            if (donvi = "C")
            {
                Console.Write("nhap nhiet do C: ");
                double nhietdoC = double.Parse(Console.ReadLine());
                double nhietdoF = nhietdoC * (9 / 5) + 32;
                Console.WriteLine($"Nhiet do F la: {nhietdoF}");

            }

            else
            {
                Console.Write("nhap nhiet do F: ");
                double nhietdoF = double.Parse(Console.ReadLine());
                double nhietdoC = (nhietdoF - 32) / (9 / 5);
                Console.WriteLine($"Nhiet do C la: {nhietdoC}");
            }
        }

        public static void Question_06()
        {
            Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
            Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
            Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
            Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
            Console.WriteLine("Size of bool: " + sizeof(bool) + " bytes");
        
        }

        public static void Question_07()
        {
            Console.WriteLine("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nASCII value of '{ch}' is {(int)ch}.");
        }


    }

