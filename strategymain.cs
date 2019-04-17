class Program
{
    static void Main(string[] args)
    {
        float todayPrice = 2;
        float yesterdayPrice = 3;

        ITrading algorithm = null;

        if (todayPrice < yesterdayPrice)
        {
            algorithm = new LowerAlgorithm();
        }
        else if(todayPrice > yesterdayPrice)
        {
            algorithm = new HigherAlgorithm();
        }
        else
        {
            algorithm = new EqualAlgorithm();
        }

        algorithm.Trade();

        Console.ReadKey();
    }
}
