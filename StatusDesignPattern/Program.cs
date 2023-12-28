// See https://aka.ms/new-console-template for more information
using StatusDesignPattern;

Console.WriteLine("Hello, World!");
Tv tv = new Tv();
//Console.WriteLine(tv.Status.ToString());

tv.PowerPush();
//Console.WriteLine(tv.Status.ToString());
tv.PowerPush();
//Console.WriteLine(tv.Status.ToString());
Console.WriteLine("Hello, World!");




AlertStateContext alertStateContext = new AlertStateContext();
alertStateContext.setState(new Vibration());
alertStateContext.Alert();

alertStateContext.setState(new Silent());
alertStateContext.Alert();






