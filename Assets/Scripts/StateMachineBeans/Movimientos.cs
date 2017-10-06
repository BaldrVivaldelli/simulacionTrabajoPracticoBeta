using UnityEngine;

public abstract class Movimientos
{

    private float _speed;
    private float _rotationSpeed;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="speed">Velocidad de movimiento.</param>
    public Movimientos(float speed)
    {
        _rotationSpeed = .8f;
        _speed = speed;
    }

    /// <summary>
    /// Movimiento del cuerpo.
    /// </summary>
    /// <param name="dirToGo">Direccion hacia donde ir.</param>
    /// <param name="transform"></param>
    public void Move(Vector3 dirToGo, Transform transform)
    {
        transform.forward = Vector3.Lerp(transform.forward, dirToGo, _rotationSpeed * Time.deltaTime);
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    /// <summary>
    /// Obtiene la distancia entre dos objetos.
    /// </summary>
    /// <param name="current">Objeto a calcular.</param>
    /// <param name="objetive">Objetivo de distancia.</param>
    /// <returns>Distancia entre objetos.</returns>
    public float GetDistance(Transform current, Transform objetive)
    {
        return Vector3.Distance(current.position, objetive.position);
    }
}
