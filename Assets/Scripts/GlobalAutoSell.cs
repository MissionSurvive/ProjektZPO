using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoSell : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public int currentMoney;
    public static int AutoSellValue = 1;
    public static bool MakeButtonFake = false;
    public GameObject AutoSellStat;
    public static int AutoSellLevel;
    public static int AutoSellLevel2;

    void Update()
    {
       currentMoney = GlobalMoney.MoneyCount;
       AutoSellStat.GetComponent<Text>().text="AutoSell/1sec: " + AutoSellLevel;
       fakeText.GetComponent<Text>().text="Buy AutoSell: $" + AutoSellValue;
       realText.GetComponent<Text>().text="Buy AutoSell: $" + AutoSellValue;
       if (currentMoney >= AutoSellValue)
       {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
       }
       else
       {
          fakeButton.SetActive(true);
          realButton.SetActive(false);
       }
       if (MakeButtonFake == true)
       {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            MakeButtonFake = false;
       }
    }
}
