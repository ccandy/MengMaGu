using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    protected bool _enterTriggerEnter = false;
    protected PlayerController _playerController;

    private void Awake()
    {
        _playerController = GameManager.Instance.Player;
    }

    public virtual void OnClickedAction()
    {
        Debug.Log("OnClickAction");
    }
    public virtual void EmptyClicked()
    {
        Debug.Log("EmptyClick");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Enter player");
            _enterTriggerEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            _enterTriggerEnter = false;
        }     
    }
}
