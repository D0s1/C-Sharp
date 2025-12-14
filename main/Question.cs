
public class Question
{
    private const int ValueMin = 1;
    private const int ValueMax = 1000;
    private static readonly Random Random = new ();
    private readonly int _value1;
    private readonly int _value2;
    private readonly char _sign;

    public int Result { get; }

    private Question(int value1, int value2, char sign, int result)
    {
        _value1 = value1;
        _value2 = value2;
        _sign = sign;
        this.Result = result;
    }

    public static Question Generate(bool isEasyMode)
    {
        var value1 = Random.Next(ValueMin, ValueMax);
        var value2 = Random.Next(ValueMin, ValueMax);
        var (sign, result) = Random.Next(1,4) switch
        {
            1 => ('+', value1 + value2),
            2 => ('-', value1 - value2),
            3 => ('*', value1 * value2),
            _ => throw new InvalidOperationException()
        };
        if (isEasyMode && sign == '*')
        {
            value1 = value1 / 10;
            value2 = value1 / 10;
            result = value1 * value2;
        }

        return new Question(value1, value2, sign, result);
    }

    public bool IsValid(int result) => this.Result == result;

    public override string ToString()
    {
        return $"{_value1} {_sign} {_value2}";
    }
}