using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        //PlaySound("Select");

        /* Loads the next scene!
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        */
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void TrophyRoom()
    {
        SceneManager.LoadScene(2);
    } 
}
