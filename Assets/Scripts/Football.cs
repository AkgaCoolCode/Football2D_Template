using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Football : MonoBehaviour
{
    private Vector3 startPos;
    private Rigidbody2D rigidbody; 

    public void Reset()
    {
        transform.position = startPos;
        rigidbody.velocity = Vector2.zero;
        rigidbody.angularVelocity = 0;                                                                                                                                 
    }




    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }
}
