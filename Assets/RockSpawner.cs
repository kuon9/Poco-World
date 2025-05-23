using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField] GameObject rock;
    [SerializeField] Transform [] RockSpawnPoints;
    [SerializeField] float TimeBetweenRocks = 5f;
    //public static bool isActive = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnDemRocks();    
    }


    public void SpawnDemRocks()
    {
        StartCoroutine(RockSpawn());    
    }

    IEnumerator RockSpawn()
    {
        while(true) // This will run indefinitely until stopped manually
        {
            // Loop through all spawn points
            foreach(var RockSpawnPoint in RockSpawnPoints)
        {
            Instantiate(rock, RockSpawnPoint.position, RockSpawnPoint.rotation);
            yield return new WaitForSeconds(TimeBetweenRocks);

        }
     
        }
    }
}
