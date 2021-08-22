using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler2 : MonoBehaviour
{
    private int selectObstacle;
    public float timer;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;

    private void Awake()
    {
        StartCoroutine(GenerateObstacle());
    }

    private IEnumerator GenerateObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(timer);

            selectObstacle = Random.Range(1, 7);

            switch (selectObstacle)
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
                case 6:
                    Instantiate(obstacle6);
                    break;
            }

        }
    }
}
