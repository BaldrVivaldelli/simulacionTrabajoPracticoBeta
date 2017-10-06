public abstract class HumanoState : State
{

    protected Humano humano;

    public HumanoState(StateMachine sm, Humano h) : base(sm)
    {
        humano = h;
    }
}