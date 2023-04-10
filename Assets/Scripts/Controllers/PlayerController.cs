using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public readonly PlayerIdleState PlayerIdleState = new PlayerIdleState();
    public readonly PlayerMoveState PlayerMoveState = new PlayerMoveState();
    
    private BaseState<PlayerController> _currentState;

    private Animator _playerAnimator;
    private SpriteRenderer _spriteRenderer;
    private bool _flipX = false;

    public float PlayerMoveSpeed = 1.0f;
    private Vector3 _destPos = Vector3.zero;
    private Vector3 _currentDir = Vector3.right;
    
    public Vector3 DestPos
    {
        set
        {
            _destPos = value;
            CheckFlipX();
        }
        get
        {
            return _destPos;
        }
    }
    
    
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

        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (_spriteRenderer == null)
        {
            Debug.LogError("Sprint Render has no animator");
        }
        TransitionToState(PlayerIdleState);
    }

    public bool PlayerMove()
    {   
        Vector3 currentPos = gameObject.transform.position;
        currentPos = Vector2.MoveTowards(currentPos, DestPos, PlayerMoveSpeed * Time.deltaTime);
        gameObject.transform.position = currentPos;
        
        
        return (Vector3.Distance(currentPos, DestPos) >= 0.001f);
    }
    
    public void TransitionToState(BaseState<PlayerController> state)
    {
        _currentState = state;
        _currentState.EnterState(this);
    }

    private void CheckFlipX()
    {
        Vector3 newDir =  _destPos - gameObject.transform.position;
        float dir = Vector3.Dot(_currentDir, newDir);
        
        Debug.Log("Dir is " + dir);
        
        if (dir < 0.0f)
        {
            _flipX = !_flipX;
            _spriteRenderer.flipX = _flipX;
        }

        _currentDir = newDir;
    }
    
    void Update()
    {
        if (_currentState != null)
        {
            _currentState.OnUpdate(this);
        }
    }
}
