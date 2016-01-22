using UnityEngine;
using System.Collections;

public class FundPerSec : MonoBehaviour {

    public UnityEngine.UI.Text fpsDisplay;
    public Click click;
    public ItemManager[] items;

    void Start()
    {
        StartCoroutine(AutoTick());
    }

    void Update()
    {
        fpsDisplay.text = GetFundPerSec() + " funds/sec.";
    }

    public int GetFundPerSec()
    {
        int tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }

        return tick;
    }

    public void AutoFundPerSec()
    {
        click.funds += GetFundPerSec();
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoFundPerSec();
            yield return new WaitForSeconds(1);
        }
    }

}
