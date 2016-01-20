using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text fpc;
    public UnityEngine.UI.Text fundsDisplay;
    public float funds = 0;
    public int fundsPerClick = 1;

    void Update()
    {
        fundsDisplay.text = "Funds: $" + funds;
        fpc.text = "Funds/Click: " + fundsPerClick;
    }

    public void Clicked()
    {
        funds += fundsPerClick;
    }

}
