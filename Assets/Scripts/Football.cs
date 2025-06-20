using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Football : MonoBehaviour
{
    public static Football Instance; 

    [SerializeField] private GameObject fireSpeed;
    [SerializeField] private Sprite roboImage;

    private Vector3 startPos;
    private Rigidbody2D rb;
    private Sprite footballImage;
    private SpriteRenderer renderer;


    public void ToggleRoboImage(bool isActive)
    {
        if (isActive)
        {
            renderer.sprite = roboImage;
        }
        else 
        {
            renderer.sprite = footballImage;
        }
    }
    public void Reset()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0;                                                                                                                       
    }




    private void Start()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        footballImage = renderer.sprite;
        startPos = transform.position;

    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
 
        fireSpeed.SetActive(false);

    }



    public void FireBall(Transform target)
    {
        fireSpeed.SetActive(true);
        rb.velocity = (target.position - transform.position).normalized * 75;
        transform.up = transform.position - target.position;
    }

    public void RoboMovement(Vector3 direction)
    {
        rb.velocity = direction * 5;
    }
     
}
