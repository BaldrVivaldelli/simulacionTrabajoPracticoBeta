using System.Collections.Generic;
using System;

public class StateMachine
{

    State _currentState;
    List<State> _states = new List<State>();

    /// <summary>
    /// Llama al execute del estado actual.
    /// </summary>
	public void Update()
    {
        if (_currentState != null)
        {
            if (SearchState(_currentState.GetType()) >= 0)
            {
                _currentState.Execute();
            }
        }
    }

    /// <summary>
    /// Agrega un estado.
    /// </summary>
    /// <param name="s">El estado a agregar.</param>
    public void AddState(State s)
    {
        if (SearchState(s.GetType()) < 0)
        {
            _states.Add(s);
        }
    }

    /// <summary>
    /// Cambia de estado.
    /// </summary>
    /// <param name="s">Tipo de estado.</param>
    public void SetState<T>() where T : State
    {
        foreach (var state in _states)
        {
            if (state.GetType() == typeof(T))
            {
                if (_currentState != null)
                {
                    _currentState.Sleep();
                }
                _currentState = state;
                _currentState.Awake();
            }
        }
    }

    /// <summary>
    /// Valida si es el estado actual.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public bool IsActualState<T>() where T : State
    {
        return typeof(T) == _currentState.GetType();
    }

    /// <summary>
    /// Busca el índice de un estado por su tipo.
    /// </summary>
    /// <param name="t">Tipo de estado.</param>
    /// <returns>Devuelve el índice.</returns>
    private int SearchState(Type t)
    {
        return _states.FindIndex(x => x.GetType() == t);
    }

    /// <summary>
    /// Limpia el estado actual.
    /// </summary>
    public void CleanState()
    {
        _currentState = null;
    }
}
