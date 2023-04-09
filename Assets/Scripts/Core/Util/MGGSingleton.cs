using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGGSingleton<T> : MonoBehaviour
{
    private static T _instance;

    public T Instance
    {
        get { return _instance; }
    }
}
