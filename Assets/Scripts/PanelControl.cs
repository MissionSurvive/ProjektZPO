using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    public GameObject panel;
    public GameObject openPanelButton;
    public GameObject closePanelButton;
    public void OpenPanel()
    {
        if(panel != null)
        {
            panel.SetActive(true);
        }
    }
    public void ClosePanel()
    {
        if(panel != null)
        {
            panel.SetActive(false);
        }
    }
}
