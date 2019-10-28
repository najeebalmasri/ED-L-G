using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GamesMenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        //PlaySound("Select");

        /* Loads the next scene!
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        */
    }

    public void TF()
    {
        SceneManager.LoadScene(3);
        //PlaySound("Select");

        /* Loads the next scene!
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        */
    }

    public void MC()
    {
        SceneManager.LoadScene(4);
        //PlaySound("Select");

        /* Loads the next scene!
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        */
    }

    public void DD()
    {
        SceneManager.LoadScene(5);
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
}
