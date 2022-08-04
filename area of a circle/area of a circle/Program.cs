namespace area_of_a_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calculate the area of a circle
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);

            // more calculations
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);

            // road trip
            Console.WriteLine("Enter miles per gallon of your car: ");
            double mpg = double.Parse(Console.ReadLine());

            double driveInCircle = circumference / mpg;
            Console.WriteLine("It will take " + driveInCircle + " gallons of gas to drive in a circle with a circumference of " + circumference + " miles.");
        }
    }
}