using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState<T> where T : Component
{
    public abstract void EnterState(T controller);
    public abstract void ExitState(T controller);
    public abstract void OnUpdate(T controller);
}
