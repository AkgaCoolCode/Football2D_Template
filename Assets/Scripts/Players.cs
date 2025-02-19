using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private Rigidbody2D RB;
    [SerializeField] private int playerNumber;
    [SerializeField] private Transform GroundCheck;
    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float ySpeed = RB.velocity.y;
        if (Input.GetButton("Vertical" + playerNumber))
        {
            ySpeed = 10;
        }    
        RB.velocity = new Vector2(10*Input.GetAxis("Horizontal"+ playerNumber),ySpeed);
    }
}