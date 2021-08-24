using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererPoints : MonoBehaviour
{
    public Transform[] points;
    public LineController line;

    private void Start()
    {
        line.SetupLine(points);
    }
}
