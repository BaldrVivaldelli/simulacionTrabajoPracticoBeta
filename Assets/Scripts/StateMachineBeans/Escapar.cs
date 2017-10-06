using UnityEngine;

public class Escapar : Movimientos
{

    private GameObject _target;
    private Vector3 _dirToGo;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="target"></param>
    public Escapar(float speed, GameObject target) : base(speed)
    {
        _target = target;
    }

    /// <summary>
    /// Ejecucion de behavior.
    /// </summary>
    /// <param name="transform">Transform de NPC.</param>
    public void Execute(Transform transform)
    {
        _dirToGo = -(_target.transform.position - transform.position);
        Move(_dirToGo, transform);
    }

    /// <summary>
    /// Obtiene la distancia entre el objeto y el objetivo.
    /// </summary>
    /// <param name="current">Objeto a calcular.</param>
    /// <param name="objetive">Objetivo de distancia.</param>
    /// <returns>Distancia entre objetos.</returns>
    public float GetDistance(Transform transform)
    {
        return GetDistance(transform, _target.transform);
    }
}
