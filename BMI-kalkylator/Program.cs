namespace BMI_kalkylator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("BMI-kalkyl");


            Console.WriteLine("Välj enhet (m för metric, i för imperial): ");
            string unitChoice = Console.ReadLine();
            string unit = unitChoice?.ToLower() == "m" ? "metric" : "imperial";

            double weight, height;

            if (unit == "metric")
            {
                Console.WriteLine("Ange vikt i kg:");
                weight = GetValidDoubleInput();

                Console.WriteLine("Ange längd i meter:");
                height = GetValidDoubleInput();
            }
            else
            {
                Console.WriteLine("Ange vikt i pounds:");
                weight = GetValidDoubleInput();

                Console.WriteLine("Ange längd i inches:");
                height = GetValidDoubleInput();
            }
            double bmi = CalculateBMI(weight, height, unit);
            Console.WriteLine($"Ditt BMI är {bmi:F2}");
        }

        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Vikt och längd måste vara positiva tal.");
                return 0;
            }
            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return 703 * (weight / (height * height));
            } else
            {
                Console.WriteLine("Okänd enhet reunerar 0");
                return 0;
            }
        }

        static double GetValidDoubleInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result) && result > 0)
                {
                    return result;
                }
                else
                     {
                    Console.WriteLine("Ogiltig inmatning. Vänligen ange ett positivt tal:");
                     }
            }
        }
    }
}
