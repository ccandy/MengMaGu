using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MGGSingleton<UIManager>
{

    public List<GameObject> UIList;
    private GameObject _currentUI;
    public void LoadUI(int index)
    {
        if (index > UIList.Count)
        {
            Debug.LogError("Fail to load UI");
            return;
        }

        if (_currentUI != null)
        {
            Destroy(_currentUI);
        }
        _currentUI = Instantiate(UIList[index]);
    }
}
