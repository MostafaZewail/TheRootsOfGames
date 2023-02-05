using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rigid;
    [SerializeField] private Transform ball;
    public float offset = 0.2f;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    private void Update()
    {
        MoveTheEnemy();
    }

    private void MoveTheEnemy()
    {
        if (ball.position.z > transform.position.z + offset)
        {
            rigid.velocity = Vector3.forward * speed;
        }else if(ball.position.z < transform.position.z - offset)
        {
            rigid.velocity = Vector3.back* speed;
        }
        else { rigid.velocity = Vector3.zero; }
    }
}
