using UnityEngine;
using System.Collections;
using System;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    public float baseCost;

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: " + clickPower;
    }

    public void PurchasedUpgrade()
    {
        if(click.funds >= cost)
        {
            click.funds -= cost;
            count += 1;
            click.fundsPerClick += clickPower;
            cost = baseCost * Convert.ToSingle(Math.Pow(1.15, count));
            cost = Convert.ToSingle(Math.Round(cost));
        }
    }
}
