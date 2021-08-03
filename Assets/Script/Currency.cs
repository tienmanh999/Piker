using UnityEngine;
using UnityEngine.UI;


public class Currency : MonoBehaviour
{
    public Text moneytxt;
    public Text picktxt;

    void Update()
    {
        moneytxt.text = "MONEY " + PlayerStart.Money.ToString();
        picktxt.text = "PICK LEFT: " + PlayerStart.Pick.ToString();
    }
}
