public class NumberGuesser{
    private readonly int _lowerBorder;
    private readonly int _higherBorder;
    private readonly int _number;

    private static readonly Random _random = new();

    public NumberGuesser()
    {
        int intervallBorder1 = _random.Next(0, 100);
        int intervallBorder2 = _random.Next(0, 100);
        _lowerBorder = Math.Min(intervallBorder1, intervallBorder2);
        _higherBorder = Math.Max(intervallBorder1, intervallBorder2);
        _number = _random.Next(_lowerBorder, _higherBorder);
    }

    public bool IsNumber(int numberGuessed)
    {
        return numberGuessed == _number;
    }

    public string Relation(int numberGuessed)
    {
        return IsNumber(numberGuessed) ? "same value!" : numberGuessed < _number ? "higher" : "lower";
    }

    public void PrintIntervall()
    {
        Console.WriteLine($"Number is between {_lowerBorder} and {_higherBorder} !");
    }

}