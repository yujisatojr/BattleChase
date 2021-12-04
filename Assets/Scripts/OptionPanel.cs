using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionPanel : MonoBehaviour
{
    public GameObject menuPane;
    public GameObject OptionPane;
    
    public void OpenOptionPane()
    {
        menuPane.SetActive(false);
        OptionPane.SetActive(true);
    }

    public void CloseOptionPane()
    {
        menuPane.SetActive(true);
        OptionPane.SetActive(false);
    }
}
