using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    protected bool _enterTriggerEnter = false;
    
    protected virtual void OnClickedAction()
    {
        Debug.Log("OnClickAction");
    }
    public virtual void EmptyClicked()
    {
        Debug.Log("EmptyClick");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _enterTriggerEnter = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _enterTriggerEnter = false;
    }
}
