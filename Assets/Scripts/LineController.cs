using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;
    private float lrPoint1;
    private float lrPoint2;
    Color c1 = new Color(1, 0.4f, 0.4f, 1);
    Color c2 = new Color(1, 0.07f, 0.07f, 1);

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        //lrPoints[0] = new Vector3(0,0,0);
        //lrPoints[1] = new Vector3(0,0,0);
        
    }

    public void SetupLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
    }

    private void Update()
    {
        for(int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }

        lrPoint1 = lr.GetPosition(0).y;
        lrPoint2 = lr.GetPosition(1).y;

        if((lrPoint1 - lrPoint2) > 2.6)
        {
            lr.startColor = c2;
            lr.endColor = c2;
        }
        else
        {
            lr.startColor = c1;
            lr.endColor = c1;
        }
    }
}
