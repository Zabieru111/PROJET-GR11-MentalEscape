using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int keyTakenNumber = 0;
    public int minutes = 10;
    public float secondes = 0f;
    public string tempRestant;



    public void addKey()
    {
        keyTakenNumber++;
    }
    public void Awake()
    {
        tempRestant = " ";
        if (instance !=null)
        {
            Destroy(instance);

        }
        else {
            instance = this;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Pour update le text du timer
    void Update()
    {
        if (minutes >= 0)
        {
            if (secondes > 0f)
            {
                secondes -= Time.deltaTime;
            }
            if (secondes <= 0f && minutes > 0)
            {
                minutes--;
                secondes = 60f;
            }

        }
        if (secondes > 10f)
        {
            tempRestant = minutes + ":" + (int)secondes;
        }
        else
        {
            tempRestant = minutes + ":0" + (int)secondes;
        }
        if (minutes == 0 && secondes == 0f)
        {
        }
    



}


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadSceneMainMenu() 
    {
        SceneManager.LoadScene("");
    }
    public void LoadSceneChimie()
    {
        SceneManager.LoadScene("");
    }
    public void LoadSceneHistoire()
    {
        SceneManager.LoadScene("");
    }
    public void LoadSceneMath()
    {
        SceneManager.LoadScene("");
    }




}
