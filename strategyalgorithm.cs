public class HigherAlgorithm : ITrading
{
    public TradingDecision Trade()
    {
        Console.WriteLine("Higher Algorithm Decision : Buy");
        return new TradingDecision
        {
            _orderType = OrderType.BUY,
            equity = 1.2f
        };
    }
}

public class LowerAlgorithm : ITrading
{
    public TradingDecision Trade()
    {
        Console.WriteLine("Lower Algorithm Decision : Sell");
        return new TradingDecision
        {
            _orderType = OrderType.SELL,
            equity = 0.8f
        };
    }
}

public class EqualAlgorithm : ITrading
{
    public TradingDecision Trade()
    {
        Console.WriteLine("Higher Algorithm Decision");
        return new TradingDecision
        {
            _orderType = OrderType.BUY,
            equity = 0.2f
        };
    }
}
