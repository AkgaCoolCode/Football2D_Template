using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnPowerUp),9,9);
    }

    private void SpawnPowerUp()
    {
        Instantiate(powerUp, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
