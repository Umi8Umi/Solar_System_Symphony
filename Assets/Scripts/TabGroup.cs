using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public TabButton selectedTab;

    public void Subscribe(TabButton button)
    {
        if(tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if(selectedTab == null || button != selectedTab)
        { 
            button.GetComponent<Image>().color = new Color(225, 248, 0);
        }
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        selectedTab = button;
        ResetTabs();
        button.GetComponent<Image>().color = new Color(225, 0 , 237);
    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if(selectedTab != null && button == selectedTab) { continue;  }
            button.GetComponent<Image>().color = Color.black;
        }
    }
}
