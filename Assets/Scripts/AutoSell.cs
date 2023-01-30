using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public static bool AutoSellPoint = false;
    public static int MoneyIncrease = 1;
    public static int PointDecrease = 1;
    public int InternalIncrease;
    public int InternalDecrease;
    void Update()
    {
        MoneyIncrease = GlobalAutoSell.AutoSellLevel;
        PointDecrease = GlobalAutoSell.AutoSellLevel2;
        InternalIncrease = MoneyIncrease;
        InternalDecrease = PointDecrease;
       if (AutoSellPoint == false)
       {
            AutoSellPoint = true;
            StartCoroutine(SellThePoint());
       } 
    }
    IEnumerator SellThePoint ()
    {
        if (GlobalPoint.PointCount == 0)
        {
            AutoSellPoint = false;
        }
        else
        {
            AutoSellPoint = true;
            GlobalMoney.MoneyCount += InternalIncrease;
            GlobalPoint.PointCount -= InternalDecrease;
            yield return new WaitForSeconds(1);
            AutoSellPoint = false;
        }
        if (GlobalPoint.PointCount < InternalDecrease)
        {
            AutoSellPoint = false;
            GlobalPoint.PointCount += InternalDecrease;
            GlobalMoney.MoneyCount -= InternalIncrease;
        }
    }
}
