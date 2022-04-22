using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{

  public  void clickPlayChimie()
    {
        SceneManager.LoadScene("Science");
    }
    public void clickPlayMath()
    {
        SceneManager.LoadScene("Math");
    }
    public void clickPlayHistoire()
    {
        SceneManager.LoadScene("Histoire");
    }
    public void clickTutoriel()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void clickLeave()
    {
#if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(0);
#endif
    }
}
