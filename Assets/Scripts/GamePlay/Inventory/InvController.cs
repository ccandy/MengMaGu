using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InvController: MonoBehaviour
{
    private List<ItemController> _itemList;

    public List<ItemController> ItemList
    {
        get
        {
            return _itemList;
        }
    }
    
    private void Start()
    {
        _itemList = new List<ItemController>();
    }
    
    public void UseItem(int index)
    {
        if (index >= _itemList.Count)
        {
            return;
        }

        ItemController iC = _itemList[index];
        iC.UseItem();
    }
}
