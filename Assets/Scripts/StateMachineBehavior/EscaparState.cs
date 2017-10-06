using UnityEngine;

public class EscaparState : HumanoState
{
    public Escapar escapar;
    public EscaparState(StateMachine sm, Humano h) : base(sm, h)
    {
    }

    public override void Awake()
    {
        escapar = new Escapar(humano.GetSpeed(), humano.GetZombie());
        base.Awake();
    }

    public override void Execute()
    {
        escapar.Execute(humano.transform);
        base.Execute();
    }

    public override void Sleep()
    {
        base.Sleep();
    }
}