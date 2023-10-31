using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void startOnePlayer()
    {
        SceneManager.LoadScene("pongOnePlayer");
    }
    public void startPlayerOne()
    {
        SceneManager.LoadScene("pongPlayerOne");
    }
    public void startHardcore()
    {
        SceneManager.LoadScene("hardcorePong");
    }
}