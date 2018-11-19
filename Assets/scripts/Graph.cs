using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public Transform Point;
    public int i;
    private void Awake()
    {
       for(i=0;i<10;i++)
        {
            Transform point1 = Instantiate(Point);
            point1.localPosition = Vector3.right * i;
        }
       
    }

}
