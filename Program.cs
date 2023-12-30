namespace examFractions
{
    class Program
    {
        static void Main()
        {
            //example:
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 5);
            
            Fraction fraction3 = fraction1 + fraction2;

            Console.WriteLine($"{fraction1} + {fraction2} = {fraction3}");
        }
    }
}