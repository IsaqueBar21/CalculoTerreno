Console.WriteLine("Land Measurements");
Console.WriteLine("-----------------");

//inputs
Console.WriteLine("Enter the Width of the plot");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Lenght of the plot");
double lenght = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value of the Square Meter of land");
double valueSquaremeter = double.Parse(Console.ReadLine());

//processing
double area = width * lenght;
double price = area * valueSquaremeter;

//output
Console.WriteLine("Plot Area: " + area.ToString("F2"));
Console.WriteLine("Land Price: " + price.ToString("F2"));


