using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    public Color standard;
    public Color affordable;
    private Slider _slider;
    private float baseCost;

    void Start()
    {
        baseCost = cost;
        _slider = GetComponentInChildren<Slider>();
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nGold: " + tickValue + "/s";

        /*if (click.funds >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }*/
        _slider.value = click.funds / cost * 100;
        if (_slider.value >= 100)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }
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
