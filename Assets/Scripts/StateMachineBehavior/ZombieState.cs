using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieState : State
{

    protected Zombie zombie;

    public ZombieState(StateMachine sm, Zombie z) : base(sm)
    {
        zombie = z;
    }
}
