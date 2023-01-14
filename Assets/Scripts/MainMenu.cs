using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string sceneToLoad = "PlayScene";
    // Play button changes the scene to the game scene
    public void Play()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    // Quit button quits the game
    public void Quit()
    {
        Application.Quit();
        // debug message
        Debug.Log("Player Has Quit The Game");
    }
}
