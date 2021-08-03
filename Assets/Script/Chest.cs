using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;


public class Chest : MonoBehaviour
{
    [HideInInspector]
    public GameObject item;

    public InfoUI Info_UI;
    public int costTopick;
    [HideInInspector]
    public List<InfoItem> itemList = new List<InfoItem>();
    [HideInInspector]
    public List<InfoItem> allItem;

    public Transform spwaner;
    public bool isPicked = false;

    public void Button()
    {
        allItem = Gamedata.instance.infotable;
        if (isPicked)
        {
            return;
        }

        if (PlayerStart.Pick == 0 )
        {
            return;
        }
        calculator();
        PlayerStart.Pick--;
    }
    
    //public InfoItem GetItemByID()
    //{
    //    ///caculated ID
    //    /// ID = 111
    //    /// allItem.
    //    /// 
    //    //foreach (var item in allItem)
    //    //{
    //    //    if (item.ID == ID)
    //    //        return item;
    //    //}
    //}
    void calculator()
    {
        int sum = 0;
        foreach (var item in allItem)
        {
            sum += item.rariry;
        }
        int random;
        random = Random.Range(0, sum);
        for (int i = 0; i < allItem.Count; i++)
        {
            int sum_rarity = 0;
            for (int j = 0; j <= i; j++)
            {
                sum_rarity += allItem[j].rariry;
            }
            int stop = sum_rarity;
            int start = stop - allItem[i].rariry;
            if (random >= start && random <= stop)
            {
                GameObject item = (GameObject)Instantiate(allItem[i].prefab, spwaner.position , Quaternion.identity);
                isPicked = true;
                Debug.Log(itemList.Count);
                Debug.Log(itemList.Contains(allItem[i]));
                if (itemList.Contains(allItem[i]))
                {
                    Debug.Log("aa");
                    PlayerStart.Money += (allItem[i].value * 2);
                }
                else
                {
                    PlayerStart.Money += allItem[i].value;
                }
                
                Info_UI.name_itemtxt.text = allItem[i].name_item;
                Info_UI.value_itemtxt.text = allItem[i].value.ToString();
                itemList.Add(allItem[i]);
                break;
            }
        }
    }
    
    
}
       
