static void Main(string[] args)
{
    var med = new Mediator();

    // Register the mediator into the components
    var comA = new ComponentA(med);
    var comB = new ComponentB(med);

    // Each component starts listening
    comA.Listen("ComponentB");
    comB.Listen("ComponentA");

    // A program action occurs that change state
    comA.ChangeState();
    comB.ChangeState();

    Console.ReadKey();
}
