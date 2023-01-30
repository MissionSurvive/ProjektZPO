using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoCollect : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public int currentMoney;
    public static int AutoCollectValue = 1;
    public GameObject AutoCollectStat;
    public static int AutoCollectLevel;
    public static bool MakeButtonFake = false;

    void Update()
    {
       currentMoney = GlobalMoney.MoneyCount;
       AutoCollectStat.GetComponent<Text>().text="AutoCollect/3sec: " + AutoCollectLevel;
       fakeText.GetComponent<Text>().text="Buy AutoCollect: $" + AutoCollectValue;
       realText.GetComponent<Text>().text="Buy AutoCollect: $" + AutoCollectValue;
       if (currentMoney >= AutoCollectValue)
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
