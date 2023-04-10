using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MGGSingleton<GameManager>
{
    private GameStartState _gameStartState = new GameStartState();
    private BaseState<GameManager> _currentState;

    private PlayerController _playerController;
    public PlayerController Player
    {
        set
        { _playerController = value; }
        get
        { return _playerController; }
    }

    private CameraController _cameraController;
    public CameraController GameCamera
    {
        set { _cameraController = value; }
        get { return _cameraController; }
    }
    
    void Start()
    {
        _currentState = _gameStartState;
        _currentState.EnterState(this);

        _playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        _cameraController = GameObject.FindWithTag("MainCamera").GetComponent<CameraController>();
        _cameraController.Player = _playerController;
        _cameraController.FollowPlayer = true;

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
