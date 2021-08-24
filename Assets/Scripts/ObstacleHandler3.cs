using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler3 : MonoBehaviour
{
    private int selectObstacle;
    public float timer;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    public GameObject obstacle7;
    public GameObject obstacle8;
    public GameObject obstacle9;
    public GameObject obstacle10;
    public GameObject obstacle11;
    public GameObject obstacle12;

    private void Awake()
    {
        StartCoroutine(GenerateObstacle());
    }

    private IEnumerator GenerateObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(timer);

            selectObstacle = Random.Range(1, 13);

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
                case 7:
                    Instantiate(obstacle7);
                    break;
                case 8:
                    Instantiate(obstacle8);
                    break;
                case 9:
                    Instantiate(obstacle9);
                    break;
                case 10:
                    Instantiate(obstacle10);
                    break;
                case 11:
                    Instantiate(obstacle11);
                    break;
                case 12:
                    Instantiate(obstacle12);
                    break;
            }

        }
    }
}
