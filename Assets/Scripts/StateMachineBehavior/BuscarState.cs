using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscarState : ZombieState {

    private Buscar _seek;
    public BuscarState(StateMachine sm, Zombie z) : base(sm, z)
    {
    }

    public override void Awake()
    {
        zombie.Animate("Walk");
        HumanoProvider humanoProvider = GameObject.FindObjectOfType<HumanoProvider>();
        if (humanoProvider.IsEmpty())
            return;
        GameObject humano = humanoProvider.GetRandomGO();
        zombie.SetHuman(humano);
        _seek = new Buscar(zombie.GetSpeed(), humano);
    }

    public override void Execute()
    {
        _seek.Execute(zombie.transform);

        if (_seek.GetDistance(zombie.transform) < 5)
            zombie.ScareHuman();
    }

    public override void Sleep()
    {
        base.Sleep();
    }
}