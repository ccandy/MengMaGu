using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemController : MonoBehaviour
{
    private bool _reuseable;

    public bool Reuseable
    {
        set
        {
            _reuseable = value;
        }
        get
        {
            return _reuseable;
        }
    }
    
    
    private string _itemDesc;
    private int _useage;
    public int Useage
    {
        set
        {
            _useage = value;
        }
        get
        {
            return _useage;
        }
    }

    public string ItemDesc
    {
        set
        {
            _itemDesc = value;
        }
        get
        {
            return _itemDesc;
        }
    }
    
    private string _itemName;
    public string ItemName
    {
        set
        {
            _itemName = value;
        }
        get
        {
            return _itemName;
        }
    }
    
    

    public abstract void Effect();
}
