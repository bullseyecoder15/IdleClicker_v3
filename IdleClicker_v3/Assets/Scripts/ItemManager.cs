using UnityEngine;
using System.Collections;
using System;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;

    void Start()
    {
        baseCost = cost;
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nGold: " + tickValue + "/s";
    }

    public void PurchasedItem()
    {
        if(click.funds >= cost)
        {
            click.funds -= cost;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
            // cost = baseCost * Convert.ToSingle(Math.Pow(1.15, count));
            // cost = Convert.ToSingle(Math.Round(cost));
        }
    }

}
