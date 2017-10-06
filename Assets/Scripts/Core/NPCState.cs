public class NPCState : State
{

    protected NPC _npc;

    public NPCState(StateMachine sm, NPC npc) : base(sm)
    {
        _npc = npc;
    }
}