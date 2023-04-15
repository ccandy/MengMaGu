using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer.Internal.Converters;
using UnityEngine;

public class PickUpItem : Interactive
{
    public int ItemID;

    public override void OnClickedAction()
    {
        if (_enterTriggerEnter)
        {
            Debug.Log("Pick up item");
            Destroy(gameObject);
        }
    }
    public override void EmptyClicked()
    {
        
    }
}
