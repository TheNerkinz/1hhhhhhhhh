using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
{
    public float speed = 5;
    
    public Rigidbody rigidbody;
    
    private Transform _playerHead;
    private bool _isFollow;
    
    public void Follow(Transform playerHead)
    {
        _playerHead = playerHead;
        _isFollow = true;

        rigidbody.useGravity = false;
    }

    public void Drop()
    {
        _isFollow = false;
        rigidbody.useGravity = true;
    }
    
    private void Update()
    {
        if (_isFollow == false)
        {
            return;
        }

        var target = _playerHead.position + _playerHead.forward * 3;
        
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * speed);
    }
}
