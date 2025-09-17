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

        }
        
    }
}
