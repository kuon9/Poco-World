using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloRockSpawner : MonoBehaviour
{
    [SerializeField] float TimeBetweenSpawn = 5f;
    [SerializeField] Transform solospawnPoint;
    [SerializeField] GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        SpawnOneRock();        
    }

    void SpawnOneRock()
    {
        StartCoroutine(SpawnOne());    
    }

    IEnumerator SpawnOne()
    {
        while(true)
        {
            Instantiate(rock, solospawnPoint.position, solospawnPoint.rotation);
            yield return new WaitForSeconds(TimeBetweenSpawn);
        }
    }
}
