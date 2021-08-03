using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "aa", menuName = "Item")]
public class InfoItem : ScriptableObject
{
    public GameObject prefab;
    public string ID;

    public int value;
    public int rariry;
    public string name_item;
}
