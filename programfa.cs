class Program { 
    static void Main(string[] args)
    { 
        AbstractFactory abstractFactory = new AbstractFactory(); 
        Client appClient = new Client(abstractFactory);
        appClient.archer.Attack();
        appClient.knight.Attack();
        Console.ReadKey();
    }
}
