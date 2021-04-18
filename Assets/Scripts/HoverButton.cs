using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class HoverButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        OnTabSelected();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnTabEnter();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnTabExit();
    }

    public void OnTabEnter()
    {
        GetComponent<Image>().color = new Color(250, 0, 200);
    }

    public void OnTabExit()
    {
        GetComponent<Image>().color = Color.black;
    }

    public void OnTabSelected()
    {
        // i like this color FA00C8
        GetComponent<Image>().color = new Color(250, 0, 200);
    }
}
