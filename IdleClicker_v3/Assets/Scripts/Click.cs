using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text fpc;
    public UnityEngine.UI.Text fundsDisplay;
    public float funds = 0;
    public int fundsPerClick = 1;

    void Update()
    {
        fundsDisplay.text = "Funds: $" + CurrencyConverter.Instance.GetCurrencyIntoString(funds, false, false);
        fpc.text = "Funds/Click: " + CurrencyConverter.Instance.GetCurrencyIntoString(fundsPerClick, false, true);
    }

    public void Clicked()
    {
        funds += fundsPerClick;
    }

}
