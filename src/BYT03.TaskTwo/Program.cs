using BYT03.TaskTwo;;

Console.WriteLine("Hello");

double x = 5;
double y = 10;

Calculator addition = new Calculator(x,y,'+');
Console.WriteLine(addition.Calculate());
Calculator substr = new Calculator(5,10,'-');
Console.WriteLine(substr.Calculate());
Calculator mult = new Calculator(5,10,'*');
Console.WriteLine(mult.Calculate());

try
{
    Calculator div = new Calculator(5, -5, '/');
    Console.WriteLine(div.Calculate());
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}

