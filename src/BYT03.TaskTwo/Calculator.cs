namespace BYT03.TaskTwo;

public class Calculator(double x, double y, char operation)
{
    private readonly double _x = x;
    private readonly double _y = y;
    private readonly char _operation = operation;
    
    public double Calculate()
    {
        switch (_operation)
        {
            case '+': return _x + _y; break;
            case '-': return _x - _y; break;
            case '*': return _x * _y; break;
            case '/':
                if (_y == 0)
                {
                    throw new DivideByZeroException("It's cannot be divided by 0");
                }
                return _x / _y; break;
            default:
                throw new Exception($"Unknown operation: {_operation}");
        }
    }
}