using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShop : MonoBehaviour
{
    public GameObject AutoUpgrade;
    public GameObject AutoUpgrade2;
    public AudioSource playPurchaseSound;
    public void StartAutoUpgrade()
    {
        playPurchaseSound.Play();
        AutoUpgrade.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalAutoCollect.AutoCollectValue;
        GlobalAutoCollect.AutoCollectValue *=2;
        GlobalAutoCollect.MakeButtonFake = true;
        GlobalAutoCollect.AutoCollectLevel +=1;
    }
    public void StartAutoUpgrade2()
    {
        playPurchaseSound.Play();
        AutoUpgrade2.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalAutoSell.AutoSellValue;
        GlobalAutoSell.AutoSellValue *=2;
        GlobalAutoSell.MakeButtonFake = true;
        GlobalAutoSell.AutoSellLevel +=1;
        GlobalAutoSell.AutoSellLevel2 +=1;
    }
}