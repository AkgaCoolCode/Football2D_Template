using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerUpName
{
    Freeze,
    FireBall,
    RoboBall
}

public class PowerUp : MonoBehaviour 
{
    [SerializeField] private PowerUpName powerName;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Players player))
        {
            switch (powerName)
            {
                case PowerUpName.Freeze:
                    player.enemyPlayer.Freeze();
                    break;
                case PowerUpName.FireBall:
                    Football.Instance.FireBall(player.EnemyGoal);
                    break;
                case PowerUpName.RoboBall:
                    player.ActivateRoboBall();
                    break;

                default:
                    

                    break;
            }       
            
            Destroy(gameObject);
        }
    }
}
