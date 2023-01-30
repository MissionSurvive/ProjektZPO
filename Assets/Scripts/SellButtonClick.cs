using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButtonClick : MonoBehaviour
{
   public GameObject textBox;
   public GameObject statusBox;
   public AudioSource playSell1Sound;
   public AudioSource playSell2Sound;
   public int randSellSound;
   public void ClickTheButton ()
   {
    randSellSound = Random.Range(1, 3);
        if (GlobalPoint.PointCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Cannot sell. Collect more.";
            statusBox.GetComponent<Animation>().Play("StatusTextAnimation");
        }
        else
        {
            if (randSellSound == 1)
            {
                playSell1Sound.Play();
            }
            else
            {
                playSell2Sound.Play();
            }
            GlobalPoint.PointCount -= 1;
            GlobalMoney.MoneyCount += 1;
        }
    }

}