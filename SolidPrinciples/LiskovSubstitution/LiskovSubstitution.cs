namespace SolidPrinciples.LiskovSubstitution;

// Violating LSP
internal class Bird
{
    public void Fly()
    {
    }
}

internal class Ostrich : Bird
{
    public new void Fly()
    {
        throw new InvalidOperationException("Ostriches can't fly");
    }
}

// Following LSP
internal interface IBird
{
    void Fly();
}

internal class Sparrow : IBird
{
    public void Fly()
    {
    }
}

internal class OstrichLsp : IBird
{
    public void Fly()
    {
    }
}