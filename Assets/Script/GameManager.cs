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
    public float mouseSensitivity = 100f;
    public porte conditionVictoire;
    public enum state { defeat, inGame, paused, victory,none };
    public state gameState;
    private bool GameMenuState = false;
    [SerializeField] GameObject menu;
    public bool usingSomething = false;
    public float afterUse;



    public void addKey()
    {
        keyTakenNumber++;
    }
    public void Awake()
    {
        tempRestant = " ";
        if (instance != null)
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
        gameState = state.inGame;
        afterUse = 0f;
    }

    // Pour update le text du timer
    void Update()
    {
        checkVictoire();
        if (afterUse < 2)
        {
            afterUse += Time.deltaTime;
        }
        if (usingSomething == false&&afterUse>1f)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                gameState = state.paused;
                OpenMenu();
            }
        }
        if (gameState == state.inGame)
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




    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadSceneMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void LoadSceneScience()
    {
        SceneManager.LoadScene("Science");
    }
    public void LoadSceneHistoire()
    {
        SceneManager.LoadScene("Histoire");
    }
    public void LoadSceneMath()
    {
        SceneManager.LoadScene("Math");
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Defeat()
    {
        gameState = state.defeat;
    }
    public void Victory()
    {
        gameState = state.victory;
    }
    public void OpenMenu()
    {
        if (GameMenuState == false)
        {
            GameMenuState = true;
            menu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    public void Resume()
    {
        gameState = state.inGame;
        GameMenuState = false;
        menu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void LeaveGame()
    {
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(0);
#endif
    }
    public void changeSensitivity(float value)
    {
        mouseSensitivity = value;
    }
    public void changeUsing()
    {
        usingSomething = !usingSomething;
        afterUse = 0f;
    }
    public void none()
    {
        gameState = state.none;
    }
    public void checkVictoire()
    {
        if (conditionVictoire.ouvert == true)
        {
            Victory();
        }
    }






}
