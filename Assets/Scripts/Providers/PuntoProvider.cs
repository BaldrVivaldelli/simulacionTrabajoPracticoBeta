using System.Collections.Generic;
using UnityEngine;

public class PuntoProvider : MonoBehaviour, Provider
{
    private List<GameObject> puntos = new List<GameObject>();
    void Awake()
    {
        foreach (Punto punto in FindObjectsOfType(typeof(Punto)))
        {
            AddGO(punto.gameObject);
        }
    }

    /// <summary>
    /// Obtiene un punto al azar.
    /// </summary>
    /// <returns></returns>
    public GameObject GetRandomGO()
    {
        return puntos[Random.Range(0, puntos.Count)];
    }

    /// <summary>
    /// Obtiene la cantidad de puntos de la lista.
    /// </summary>
    /// <returns></returns>
    public int GetCount()
    {
        return puntos.Count;
    }

    /// <summary>
    /// Obtiene lista de puntos.
    /// </summary>
    /// <returns></returns>
    public List<GameObject> GetList()
    {
        return puntos;
    }

    /// <summary>
    /// Obtiene un punto al azar diferente al recibido por parametro.
    /// </summary>
    /// <returns></returns>
    public GameObject getDiferentPunto(GameObject punto)
    {
        List<GameObject> puntosFilter = puntos.FindAll(x => x != punto);
        return puntosFilter[Random.Range(0, puntosFilter.Count)];
    }

    /// <summary>
    /// Remueve un punto de la lista.
    /// </summary>
    /// <param name="go"></param>
    public void RemoveGO(GameObject go)
    {
        puntos.Remove(go);
    }

    /// <summary>
    /// Agrega un punto a la lista.
    /// </summary>
    /// <param name="go"></param>
    public void AddGO(GameObject go)
    {
        puntos.Add(go);
    }
}
