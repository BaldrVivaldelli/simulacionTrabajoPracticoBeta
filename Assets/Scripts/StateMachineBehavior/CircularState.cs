using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularState : NPCState {

    private Circular circular;
    private GameObject _punto;
    private PuntoProvider _puntoProvider;
    public CircularState(StateMachine sm, NPC npc) : base(sm, npc)
    {
    }

    public override void Awake()
    {
        _puntoProvider = Object.FindObjectOfType<PuntoProvider>();
        _npc.Animate("Walk");
        SeekPunto(_puntoProvider.GetRandomGO());
        base.Awake();
    }

    public override void Execute()
    {
        Transform transform = _npc.GetTransform();
        if (circular.GetDistance(transform) < 2)
        {
            SeekPunto(_puntoProvider.getDiferentPunto(_punto));
        }
        circular.Execute(transform);
        base.Execute();
    }

    public override void Sleep()
    {
        base.Sleep();
    }

    private void SeekPunto(GameObject punto)
    {
        _punto = punto;
        circular = new Circular(_npc.GetSpeed(), _punto);
    }
}