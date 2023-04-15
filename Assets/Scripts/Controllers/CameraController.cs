using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    private Camera _camera;
    public bool FollowPlayer;

    private PlayerController _playerController;
    public Vector3 CameraOffset = new Vector3(-0.08f, 3.06f, -9.901f);
    
    public PlayerController Player
    {
        set
        {
            _playerController = value;
        }
        get
        {
            return _playerController;
        }
    }
    
    private void Awake()
    {
        _camera = Camera.main;
    }

    private void FollowingPlayer()
    {
        if (FollowPlayer)
        {
            _camera.gameObject.transform.position = _playerController.gameObject.transform.position + CameraOffset;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        FollowingPlayer();
    }
}
