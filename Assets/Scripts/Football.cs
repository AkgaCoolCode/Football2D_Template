using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Football : MonoBehaviour
{
    public static Football Instance; 

    [SerializeField] private GameObject fireSpeed;

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
        Instance = this;
        rigidbody = GetComponent<Rigidbody2D>();
        startPos = transform.position;

    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
 
        fireSpeed.SetActive(false);

    }



    public void FireBall(Transform target)
    {
        fireSpeed.SetActive(true);
        rigidbody.velocity = (target.position - transform.position).normalized * 75;
        transform.up = transform.position - target.position;
    }


     
}
