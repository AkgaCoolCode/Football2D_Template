using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private Rigidbody2D RB;
    [SerializeField] private int playerNumber;
    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        RB.velocity = new Vector2(10*Input.GetAxis("Horizontal"+ playerNumber),0);
    }
}
