namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2); //PI means circle lol
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the circle with a radius of {radius} is {Math.Round(AreaOfCircle(radius), 25 )}");
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
            PrintAreaOfCircle(); 
            
            // var is implicit type inferrence (we will see more of it soon)
            
            int i = 3;
            int j = 4;
            int k = ++i * j++;

            Console.WriteLine(k); // the output?




        }
    }
}
