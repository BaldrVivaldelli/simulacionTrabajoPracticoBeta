using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contrato de providers.
/// </summary>
public interface Provider
{
    /// <summary>
    /// Obtiene un GameObject random.
    /// </summary>
    /// <returns></returns>
    GameObject GetRandomGO();
    /// <summary>
    /// Obtiene listado de GameObject.
    /// </summary>
    /// <returns></returns>
    List<GameObject> GetList();
    /// <summary>
    /// Remueve un elemento de la lista.
    /// </summary>
    /// <param name="go"></param>
    void RemoveGO(GameObject go);
    /// <summary>
    /// Agrega un elemento a la lista.
    /// </summary>
    /// <param name="go"></param>
    void AddGO(GameObject go);
    /// <summary>
    /// Obtiene la cantidad de objetos de la lista.
    /// </summary>
    /// <returns></returns>
    int GetCount();
}
