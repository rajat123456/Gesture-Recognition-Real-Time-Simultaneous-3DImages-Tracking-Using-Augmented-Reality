using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Switch_Scene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Secret_Santa_Scene");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("You have quit the app");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
