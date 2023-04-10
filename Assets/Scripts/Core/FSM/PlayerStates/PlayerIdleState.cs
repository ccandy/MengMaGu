using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : BaseState<PlayerController>
{
    // Start is called before the first frame update
    public override void EnterState(PlayerController controller)
    {
        controller.PlayerAnimator.SetBool("PlayerWalk", false);
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
            //worldPosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
            worldPosition.y = controller.gameObject.transform.position.y;
            worldPosition.z = 0;
            controller.DestPos = worldPosition;
            controller.TransitionToState(controller.PlayerMoveState);
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed secondary button.");
        }
        
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Pressed middle click.");
        }
    }
}
