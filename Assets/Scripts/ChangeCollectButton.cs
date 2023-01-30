using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCollectButton : MonoBehaviour
{
    public Sprite CollectButtonImage;
    public Sprite CollectButtonImage2;
    public Button CollectButton;
    public void ChangeTheButton()
    
    {
        CollectButton.image.sprite = CollectButtonImage;
    }
    public void ChangeTheButton2()
    {
        CollectButton.image.sprite = CollectButtonImage2;
    }
}
