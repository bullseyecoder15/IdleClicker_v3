using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;

    public Color standard;
    public Color affordable;

    private Slider _slider;

    public float baseCost;

    void Start()
    {
        baseCost = cost;
        _slider = GetComponentInChildren<Slider>();
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: " + clickPower;

        /*if(click.funds >= cost)
        {
            GetComponent<Image>().color = affordable;
        } else
        {
            GetComponent<Image>().color = standard;
        } */
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
