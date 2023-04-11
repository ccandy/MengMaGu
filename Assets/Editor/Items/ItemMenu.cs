using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemMenu:EditorWindow
{
    [MenuItem("MMGTool/Create New Item")]
    private static void ShowWindow()
    {
        ItemMenu im = GetWindow<ItemMenu>();
        im.titleContent = new GUIContent("Create new Item");
    }
    
    void OnGUI () 
    {
        GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
    }
}
