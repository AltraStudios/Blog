public enum OrderType
{
    SELL,BUY
}

public struct TradingDecision
{
    public OrderType _orderType;
    public float equity;
}

public interface ITrading
{
    TradingDecision Trade();
}
