using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMoving : MonoBehaviour {

    public Transform player;
    public float attackDistance = 2;
    public float speed = 1;

    private float _playerCenter;

    private void Start()
    {
        _playerCenter = player.GetComponent<CapsuleCollider>().height / 2;
    }

    private void Update()
    {
        var targetposition = player.position + new Vector3(x:0, y:_playerCenter, z:0);
        var direction = (targetposition - transform.position).normalized;

        if (Vector3.Distance(player.position, transform.position) > attackDistance);



    }
}
