using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObstacleId
{
    Obstacle1,
    Obstacle2,
    Obstacle3,
    Obstacle4,
    Obstacle5,
}

public class ObstacleHandler : MonoBehaviour
{
    //float maxTime;
    //float timer;
    private int selectObstacle;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;

    private void Awake()
    {
        //maxTime = 1f;
        StartCoroutine(GenerateObstacle());
    }

    /*private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
        }
    }*/

    private IEnumerator GenerateObstacle()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.4f);
        
            selectObstacle = Random.Range(1, 5);

            switch(selectObstacle)
            {
                default:
                    Instantiate(obstacle1);
                    break;

                case 1:
                    Instantiate(obstacle1);
                    break;
                case 2:
                    Instantiate(obstacle2);
                    break;
                case 3:
                    Instantiate(obstacle3);
                    break;
                case 4:
                    Instantiate(obstacle4);
                    break;
                case 5:
                    Instantiate(obstacle5);
                    break;
            }
            
        }
    }
}
