using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public int SavedPoints;
    public int SavedMoney;
    public int SavedAutoCollect;
    public int SavedAutoSell;
    public int SavedAutoSell2;
    public int SavedAutoCollectValue;
    public int SavedAutoSellValue;
    void Start()
    {
        if (MainMenu.isLoading == true)
        {
            SavedPoints = PlayerPrefs.GetInt("SavedPoints");
            GlobalPoint.PointCount = SavedPoints;
            SavedMoney = PlayerPrefs.GetInt("SavedMoney");
            GlobalMoney.MoneyCount = SavedMoney;
            SavedAutoCollect = PlayerPrefs.GetInt("SavedAutoCollect");
            GlobalAutoCollect.AutoCollectLevel = SavedAutoCollect;
            SavedAutoSell = PlayerPrefs.GetInt("SavedAutoSell");
            GlobalAutoSell.AutoSellLevel = SavedAutoSell;
            SavedAutoSell2 = PlayerPrefs.GetInt("SavedAutoSell2");
            GlobalAutoSell.AutoSellLevel2 = SavedAutoSell2;
            SavedAutoCollectValue = PlayerPrefs.GetInt("SavedAutoCollectValue");
            GlobalAutoCollect.AutoCollectValue = SavedAutoCollectValue;
            SavedAutoSellValue = PlayerPrefs.GetInt("SavedAutoSellValue");
            GlobalAutoSell.AutoSellValue = SavedAutoSellValue;
            PlayerPrefs.SetInt("SavedPoints", GlobalPoint.PointCount);
            PlayerPrefs.SetInt("SavedMoney", GlobalMoney.MoneyCount);
            PlayerPrefs.SetInt("SavedAutoCollect", GlobalAutoCollect.AutoCollectLevel);
            PlayerPrefs.SetInt("SavedAutoSell", GlobalAutoSell.AutoSellLevel);
        }
    }
}
