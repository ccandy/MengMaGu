using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : BaseState<PlayerController>
{
    // Start is called before the first frame update
    private InputController _inputController;
    private bool _playerMove;
    public override void EnterState(PlayerController controller)
    {
        _inputController = controller.PlayerInputController;
        controller.PlayerAnimator.SetBool("PlayerWalk", false);
    }

    public override void ExitState(PlayerController controller)
    {
        
    }

    public override void OnUpdate(PlayerController controller)
    {
        _inputController.OnUpdate();
       _playerMove = _inputController.PlayerReachDest();

        if (_playerMove)
        {
            controller.TransitionToState(controller.PlayerMoveState);
        }
    }
}
