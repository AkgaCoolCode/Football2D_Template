using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int cooldown = 9;
    [SerializeField] private GameObject[] powerUps;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnPowerUp),   cooldown, cooldown);
    }

    private void SpawnPowerUp()
    {
        Instantiate(powerUps[Random.Range(0,1)], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

