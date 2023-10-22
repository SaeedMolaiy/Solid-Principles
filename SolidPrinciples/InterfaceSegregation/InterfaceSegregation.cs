namespace SolidPrinciples.InterfaceSegregation;

// Violating ISP
internal interface IWorker
{
    void Work();
    void Eat();
}

internal class Engineer : IWorker
{
    public void Work()
    {
    }

    public void Eat()
    {
    }
}

internal class Waiter : IWorker
{
    public void Work()
    {
    }

    public void Eat()
    {
    }
}

// Following ISP
internal interface IWorkerIsp
{
    void Work();
}

internal interface IEater
{
    void Eat();
}

internal class EngineerIsp : IWorker, IEater
{
    public void Work()
    {
    }

    public void Eat()
    {
    }
}

internal class WaiterIsp : IWorker, IEater
{
    public void Work()
    {
    }

    public void Eat()
    {
    }
}