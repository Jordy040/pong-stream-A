using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour 
{
    public void startPongOnePlayer ()
    {
        SceneManager.LoadScene("PongOnePlayer");
    }
    public void startPongTwoPlayer ()
    {
        SceneManager.LoadScene("pongTwoPlayer");
    }
}
