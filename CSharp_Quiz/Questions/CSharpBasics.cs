namespace SYMC.GLOBALIZATION.LOCALIZATION
{
    class CSharpBasics
    {

       public void LandscapeOrPortrait()
        {
           int Length;
           int Breath;
            
           Console.WriteLine("Enter length of your image:");
           Length = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Breath of your image:");
           Breath = int.Parse(Console.ReadLine());
           if (Length < Breath)
           {
               Console.WriteLine("Your image is Landscape");
           }
            else if (Length > Breath)
            {
                Console.WriteLine("Your image is Portrait");
            }
            else
            {
                Console.WriteLine("Your image is square");
            }
            }


        public void FactorialNumber()
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();
        }
        
        public void ReverseString()
       {       
                string Str, reversestring = "";
                int Length;
                Console.Write("Enter A String : ");
                Str = Console.ReadLine();
                Length = Str.Length - 1;
                while (Length >= 0)
                {
                    reversestring = reversestring + Str[Length];
                    Length--;
                }
                Console.WriteLine("Reverse  String  Is  {0}", reversestring);
                Console.ReadLine();
            }



        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        /// 
        
        
        static void Main(string[] args)
        {
          
            CSharpBasics test = new CSharpBasics();
            test.LandscapeOrPortrait();
            test.FactorialNumber();
            test.ReverseString();
           


        }


    }
}
