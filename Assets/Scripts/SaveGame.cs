using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public int saveGameMoney;
    public GameObject saveButton;
    void Update()
    {
        saveGameMoney = GlobalMoney.MoneyCount;
    }
    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedPoints", GlobalPoint.PointCount);
        PlayerPrefs.SetInt("SavedMoney", GlobalMoney.MoneyCount);
        PlayerPrefs.SetInt("SavedAutoCollect", GlobalAutoCollect.AutoCollectLevel);
        PlayerPrefs.SetInt("SavedAutoSell", GlobalAutoSell.AutoSellLevel);
        PlayerPrefs.SetInt("SavedAutoSell2", GlobalAutoSell.AutoSellLevel2);
        PlayerPrefs.SetInt("SavedAutoCollectValue", GlobalAutoCollect.AutoCollectValue);
        PlayerPrefs.SetInt("SavedAutoSellValue", GlobalAutoSell.AutoSellValue);
    }
}
