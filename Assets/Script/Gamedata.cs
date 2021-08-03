using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamedata : MonoBehaviour
{
    public List<InfoItem> infotable;

    public static Gamedata instance;

    #region singleton
    private void Awake()
    {
        instance = this;
          
    }
    #endregion 
    //private void Start()
    //{
    //    Debug.Log(infotable[0].name_item);
    //}
}
