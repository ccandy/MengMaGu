using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private PlayerController _playersController;
    public void Init(PlayerController controller)
    {
        _playersController = controller;
    }
    public void OnUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit != null && hit.collider != null)
            {
                if (hit.collider.gameObject.tag.Equals("Interactive"))
                {
                    Interactive interactive = gameObject.GetComponent<Interactive>();
                    interactive.OnClickedAction();
                }
            }
            else
            {
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            
                worldPosition.y = _playersController.gameObject.transform.position.y;
                worldPosition.z = 0;
                _playersController.DestPos = worldPosition;
            }
        }
    }

    public bool PlayerReachDest()
    {
        if (_playersController != null)
        {
            Debug.LogError("Player is null");
            return false;
        }
        return _playersController.PlayerMove();
    }
    
}
