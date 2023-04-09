using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private readonly PlayerIdleState _playerIdle = new PlayerIdleState();
    private BaseState<PlayerController> _currentState;

    private Animator _playerAnimator;

    public Animator PlayerAnimator
    {
        get
        {
            return _playerAnimator;
        }
    }

    void Start()
    {
        _playerAnimator = gameObject.GetComponent<Animator>();

        if (_playerAnimator == null)
        {
            Debug.LogError("Player has no animator");
        }
        
        TransitionToState(_playerIdle);
    }
    
    
    public void TransitionToState(BaseState<PlayerController> state)
    {
        _currentState = state;
        _currentState.EnterState(this);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (_currentState != null)
        {
            _currentState.OnUpdate(this);
        }
    }
}
