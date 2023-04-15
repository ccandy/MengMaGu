using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
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
        }
        
    }
}
