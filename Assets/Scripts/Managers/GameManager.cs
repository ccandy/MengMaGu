using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameStartState _gameStartState = new GameStartState();
    private BaseState<GameManager> _currentState;
    void Start()
    {
        _currentState = _gameStartState;
        _currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        _currentState.OnUpdate(this);
    }

    public void TransitionToState(BaseState<GameManager> state)
    {
        _currentState = state;
        _currentState.EnterState(this);
    }
}
