using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : BaseState<PlayerController>
{
    // Start is called before the first frame update

    public override void EnterState(PlayerController controller)
    {
        Debug.Log("In player move state");
        controller.PlayerAnimator.SetBool("PlayerWalk", true);
    }

    public override void ExitState(PlayerController controller)
    {
        
    }

    public override void OnUpdate(PlayerController controller)
    {
        
        Vector3 mousePos = Input.mousePosition;
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            
            worldPosition.y = 0;
            worldPosition.z = 0;
            controller.DestPos = worldPosition;
            
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed secondary button.");
        }
        
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Pressed middle click.");
        }
        
        bool playerMove = controller.PlayerMove();
        if (!playerMove)
        {
            controller.TransitionToState(controller.PlayerIdleState);
        }
    }
}
