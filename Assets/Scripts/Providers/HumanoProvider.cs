using System.Collections.Generic;
using UnityEngine;

public class HumanoProvider : MonoBehaviour, Provider
{
    [SerializeField]
    private List<GameObject> humanos = new List<GameObject>();
    void Awake()
    {
        foreach (Humano humano in FindObjectsOfType(typeof(Humano)))
        {
            AddGO(humano.gameObject);
        }
    }

    /// <summary>
    /// Obtiene la cantidad de humanos de la lista.
    /// </summary>
    /// <returns></returns>
    public int GetCount()
    {
        return humanos.Count;
    }

    /// <summary>
    /// Obtiene un humano al azar.
    /// </summary>
    /// <returns></returns>
    public GameObject GetRandomGO()
    {
        return humanos[Random.Range(0, humanos.Count)];
    }

    /// <summary>
    /// Obtiene el listado de humanos.
    /// </summary>
    /// <returns></returns>
    public List<GameObject> GetList()
    {
        return humanos;
    }

    /// <summary>
    /// Remueve un humano de la lista.
    /// </summary>
    /// <param name="go"></param>
    public void RemoveGO(GameObject go)
    {
        humanos.Remove(go);
    }

    /// <summary>
    /// Agrega un humano a la lista.
    /// </summary>
    /// <param name="go"></param>
    public void AddGO(GameObject go)
    {
        humanos.Add(go);
    }

    /// <summary>
    /// Verifica si la lista esta vacia.
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        return humanos.Count == 0;
    }
}
