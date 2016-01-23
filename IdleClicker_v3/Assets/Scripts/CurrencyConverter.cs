using UnityEngine;
using System.Collections;

public class CurrencyConverter : MonoBehaviour {

    private static CurrencyConverter instance;
    public static CurrencyConverter Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        CreateInstance();
    }

    void CreateInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick)
    {
        string converted;
        if(valueToConvert >= 1000000)
        {
            converted = (valueToConvert / 1000000f).ToString("f3") + "M";
        } else if(valueToConvert >= 1000)
        {
            converted = (valueToConvert / 1000f).ToString("f3") + "k";
        }
        else
        {
            converted = "" + valueToConvert.ToString("f1");
        }

        if (currencyPerSec == true)
        {
            converted = converted + " fps";
        }

        if (currencyPerClick == true)
        {
            converted = converted + " fpc";
        }

        return converted;
    }

}
