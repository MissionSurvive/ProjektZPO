using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectButtonClick : MonoBehaviour
{
   public GameObject textBox;
   public AudioSource playCollectSound;

   public void ClickTheButton ()
   {
      playCollectSound.Play();
      GlobalPoint.PointCount += 1;
   }
}
