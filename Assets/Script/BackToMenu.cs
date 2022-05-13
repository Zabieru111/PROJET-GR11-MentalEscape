using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    //retourne au menu
    public void clickBackMenu()
    {
        GameManager.instance.LoadSceneMainMenu();
    }
}
