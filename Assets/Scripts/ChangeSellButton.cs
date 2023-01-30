using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSellButton : MonoBehaviour
{
    public Sprite SellButtonImage;
    public Sprite SellButtonImage2;
    public Button sellButton;
    public void ChangeTheButton()
    {
        sellButton.image.sprite = SellButtonImage;
    }
    public void ChangeTheButton2()
    {
        sellButton.image.sprite = SellButtonImage2;
    }
}
