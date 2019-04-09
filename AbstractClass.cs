public abstract class DataProvider
{
    public void Fetch() {
        Console.WriteLine("Data Provider Fetch");
    }
}

public class SQLDataProvider : DataProvider
{
    public SQLDataProvider()
    {
        this.Fetch();
    }

    public new void Fetch()
    {
        base.Fetch();
        Console.WriteLine("SQL Data Provider Fetch");
    }
}
