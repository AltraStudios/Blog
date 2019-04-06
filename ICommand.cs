public interface ICommand
{
    void Execute();
}

public class DieCommand : ICommand
{
    float Health;
    public void Execute()
    {
        Die();
        Console.WriteLine("Die Command");

    }

    private void Die() {
        Health = 0;
        Scream();
    }

    private void Scream() { }
}

public class CollapseCommand : ICommand
{
    float explosion_power;

    public void Execute()
    {
        Explode();
        Console.WriteLine("Collapse Command");

    }

    private void Explode() {
        explosion_power = float.MaxValue;
        CauseFire();
    }

    private void CauseFire() { }
}

public class ExplodeCommand : ICommand
{
    float collapse_speed;

    public void Execute()
    {
        Collapse();
        Console.WriteLine("Explosion Command");
    }

    private void Collapse() {
        collapse_speed = float.MaxValue;
        CollapseSound();
    }
    private void CollapseSound() { 
        // play sound
    }
}
