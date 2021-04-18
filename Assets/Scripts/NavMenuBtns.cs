using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavMenuBtns : MonoBehaviour
{
    public GameObject ship;
    public GameObject planet;

    public void landOnPlanet()
    {
        // hex color for selected item = FF00EC
        // this.GetComponent<Image>().color = Color.red;

        ship.transform.position = planet.transform.position + planet.transform.TransformDirection(new Vector3(0, 0, (planet.transform.localScale.z / 2) + 1));
        ship.transform.parent = planet.transform;
    }
}
