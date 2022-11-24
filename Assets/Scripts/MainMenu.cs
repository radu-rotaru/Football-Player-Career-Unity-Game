using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Play button changes the scene to the game scene
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Quit button quits the game
    public void Quit()
    {
        Application.Quit();
        // debug message
        Debug.Log("Player Has Quit The Game");
    }
}
