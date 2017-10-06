using UnityEngine;
/// <summary>
/// Contrato de NPC.
/// </summary>
public interface NPC
{
    /// <summary>
    /// Devuelve la velocidad del npc.
    /// </summary>
    /// <returns>Velocidad del NPC.</returns>
    float GetSpeed();
    /// <summary>
    /// Funcion encargada de animar el NPC.
    /// </summary>
    /// <param name="animationName">Nombre de la animacion a reproducir.</param>
    void Animate(string animationName);
    /// <summary>
    /// Obtiene el atributo transform del npc.
    /// </summary>
    /// <returns></returns>
    Transform GetTransform();
}
