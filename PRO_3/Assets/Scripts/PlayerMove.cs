using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player_rb;
    [SerializeField] private float speed;
    [SerializeField] private Transform pos;

    private float h, v;
    private Vector2 dir;

    private void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        //gets axes
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        dir = new Vector2(h, v);


    }

    private void FixedUpdate()
    {
        player_rb.velocity = dir * speed;
  
    }

}
