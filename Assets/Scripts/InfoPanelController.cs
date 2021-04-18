using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoPanelController : MonoBehaviour
{
    public GameObject infoPanelUI;
    public void toggleInfo()
    {

        if (infoPanelUI.activeSelf == true)
        {
            infoPanelUI.SetActive(false);
        }
        else
        {
            infoPanelUI.SetActive(true);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        Time.timeScale = 1f;
    }
}
