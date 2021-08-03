using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InfoUI : MonoBehaviour
{
    public GameObject UI;
    public Text name_itemtxt;
    public Text value_itemtxt;

    public void SetTarget()
    {
        UI.SetActive(true);
    }
}
