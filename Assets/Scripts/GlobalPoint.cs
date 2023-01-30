using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalPoint : MonoBehaviour
{
    public static int PointCount;
    public GameObject PointDisplay;
    public int InternalPoint;
    void Update()
    {
        InternalPoint = PointCount;
        PointDisplay.GetComponent<Text>().text = "" + InternalPoint;
    }
}
