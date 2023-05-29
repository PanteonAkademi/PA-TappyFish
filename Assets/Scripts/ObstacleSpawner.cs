using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    
    public void InstantiateObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = new Vector2(transform.position.x, transform.position.y);
    }

    void Start()
    {
        InstantiateObstacle();
    }

    
    void Update()
    {
        
    }
}
