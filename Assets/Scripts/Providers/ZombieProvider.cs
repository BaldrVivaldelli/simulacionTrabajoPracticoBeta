
using System.Collections.Generic;
using UnityEngine;

public class ZombieProvider : MonoBehaviour, Provider
{
    [SerializeField]
    private List<GameObject> zombies = new List<GameObject>();
    void Awake()
    {
        foreach (Zombie zombie in FindObjectsOfType(typeof(Zombie)))
        {
            AddGO(zombie.gameObject);
        }
    }

    /// <summary>
    /// Obtiene un zombie al azar.
    /// </summary>
    /// <returns></returns>
    public GameObject GetRandomGO()
    {
        return zombies[Random.Range(0, zombies.Count)];
    }

    /// <summary>
    /// Obtiene la cantidad de zombies de la lista.
    /// </summary>
    /// <returns></returns>
    public int GetCount()
    {
        return zombies.Count;
    }

    /// <summary>
    /// Obtiene el listado de zombies.
    /// </summary>
    /// <returns></returns>
    public List<GameObject> GetList()
    {
        return zombies;
    }

    /// <summary>
    /// Remueve un zombie de la lista.
    /// </summary>
    /// <param name="go"></param>
    public void RemoveGO(GameObject go)
    {
        zombies.Remove(go);
    }

    /// <summary>
    /// Agrega un zombie a la lista.
    /// </summary>
    /// <param name="go"></param>
    public void AddGO(GameObject go)
    {
        zombies.Add(go);
    }
}
