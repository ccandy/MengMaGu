using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStopFollow : MonoBehaviour
{
    private Vector3 stopPos;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.tag.Equals("Player"))
        {
            return;
        }
        bool followPlayer = GameManager.Instance.GameCamera.FollowPlayer;
        GameManager.Instance.GameCamera.FollowPlayer = !followPlayer;
        
    }
}
