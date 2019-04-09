public class Mediator
{
    Dictionary<string, List<IComponent>> ComponentListener = new Dictionary<string, List<IComponent>>();

    public void Notify(string sourceComponent, int state)
    {
        foreach(var listener in ComponentListener[sourceComponent])
        {
            listener.Receive(sourceComponent, state);
        }
    }

    public void Listen(string target, IComponent listener)
    {
        if (ComponentListener.ContainsKey(target))
            ComponentListener[target].Add(listener);
        else
        {
            ComponentListener.Add(target, new List<IComponent>() { listener });
        }
    }
}
