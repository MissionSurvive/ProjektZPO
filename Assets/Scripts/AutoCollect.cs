using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCollect : MonoBehaviour
{
    public static bool AutoCollectPoint = false;
    public static int PointIncrease = 1;
    public int InternalIncrease;
    void Update()
    {
        PointIncrease = GlobalAutoCollect.AutoCollectLevel;
        InternalIncrease = PointIncrease;
        if (AutoCollectPoint == false)
        {
            AutoCollectPoint = true;
            StartCoroutine(CollectThePoint());
        } 
    }
    IEnumerator CollectThePoint ()
    {
        GlobalPoint.PointCount += InternalIncrease;
        yield return new WaitForSeconds(3);
        AutoCollectPoint = false;
    }
}
