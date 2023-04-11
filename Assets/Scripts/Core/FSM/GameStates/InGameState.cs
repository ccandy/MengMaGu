using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameState : BaseState<GameManager>
{
    public override void EnterState(GameManager controller)
    {
        UIManager.Instance.LoadUI(0);
    }

    public override void ExitState(GameManager controller)
    {
        
    }

    public override void OnUpdate(GameManager controller)
    {
        
    }
}
