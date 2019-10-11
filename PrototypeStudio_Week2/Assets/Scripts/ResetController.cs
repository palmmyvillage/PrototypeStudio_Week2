using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetController : MonoBehaviour
{
    public KeyCode resetSceneButton;
    public KeyCode resetGameButton;
    public KeyCode exitgameButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetScene();
        ResetGame();
        ExitGame();
    }

    void ResetScene()
    {
        if (Input.GetKeyDown(resetSceneButton))
        {
            Debug.Log("Palmmy ResetScene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void ResetGame()
    {
        if (Input.GetKeyDown(resetGameButton))
        {
            Debug.Log("Palmmy Game");
            SceneManager.LoadScene(0);
        }
    }

    void ExitGame()
    {
        if (Input.GetKeyDown(exitgameButton))
        {
            Debug.Log("Palmmy Exit Game");
            Application.Quit();
        }
    }
}
