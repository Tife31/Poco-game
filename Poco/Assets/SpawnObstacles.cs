//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


class SpawnObstacles: MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int totalObsCreated = 0; 
    public Transform playerLocation;//wherever the player is located in the z direction, create a new obstacle and
                                    //place it someplace.
    private float nextPlayerPos = 10f;
    public float obstacleDist = 100f;
    public float obstacleFrequency = 10f;

    private void FixedUpdate()
    {
        
        if (playerLocation.position.z > nextPlayerPos)//check if it is time to spawn a new obstacle by checking if the player's postion is past the amount of distance it should be away from a new obstacle.
        {

            float spawnY = Random.Range(1f, 20f);

            float spawnX = Random.Range(-7.5f, 7.5f);

            Vector3 spawnPosition = new Vector3(spawnX, spawnY, nextPlayerPos + obstacleDist);
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
            //Instantiate(obstaclePrefab, new Vector3(0.4f, 2, 10.8f), Quaternion.identity);
            totalObsCreated++;

            nextPlayerPos += obstacleFrequency;
        }
        
        
    }
}

