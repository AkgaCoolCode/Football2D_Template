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
        RaycastHit2D hit = Physics2D.Raycast(GroundCheck.position,Vector2.down,0.1f);
        if (Input.GetButton("Jump" + playerNumber)&&hit.collider!=null)
        {
            ySpeed = 10;
        }    
        RB.velocity = new Vector2(10*Input.GetAxis("Horizontal"+ playerNumber),ySpeed);

    }
}