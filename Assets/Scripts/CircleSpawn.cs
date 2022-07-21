using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    public GameObject circlePrefab;
    public Vector3 spawnLocation; 
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) == true)                                 // if q key is pressed
        { float randomX = Random.Range(-0.5f, 0.5f);
            spawnLocation.x = spawnLocation.x + randomX;
            Instantiate(circlePrefab, spawnLocation, Quaternion.identity); }      //Spawns the circle
                                                                                // Instantiate = spawn, Quaternion = stops rotating

    }
}