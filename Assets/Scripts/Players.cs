using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
 


    public Transform EnemyGoal;

    public Players enemyPlayer;


    private Vector3 startPos;

    private Rigidbody2D RB;
    [SerializeField] private int playerNumber;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private GameObject iceCube;

    private bool hasRoboBall = false;

    public void ActivateRoboBall()
    {
        hasRoboBall=true;
        Football.Instance.ToggleRoboImage(true);
        CancelInvoke(nameof(DeActivateRoboBall));
        Invoke(nameof(DeActivateRoboBall), 4);
    }
    
    private void DeActivateRoboBall()
    {
        hasRoboBall = false;
        Football.Instance.ToggleRoboImage(false);
    }
    public void Freeze()
    {
        CancelInvoke(nameof(Unfreeze));
        iceCube.SetActive(true);
        Invoke(nameof(Unfreeze),4);
    }

    private void Unfreeze()
    {
        iceCube.SetActive(false);
    }


    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }


    public void Reset()
    {
        Unfreeze();
        DeActivateRoboBall();
        transform.position = startPos;
        RB.velocity = Vector2.zero;
      
    }

  
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal" + playerNumber), Input.GetAxis("Vertical" + playerNumber));
        
        if (hasRoboBall)
        {
            Football.Instance.RoboMovement(input);
        }
        else if (!iceCube.activeSelf)
        {
            float ySpeed = RB.velocity.y;
            RaycastHit2D hit = Physics2D.Raycast(GroundCheck.position, Vector2.down, 0.1f);
            if (Input.GetButton("Jump" + playerNumber) && hit.collider != null)
            {
                ySpeed = 10;
            }
            RB.velocity = new Vector2(10 * input.x, ySpeed);
        }
        

    }
}