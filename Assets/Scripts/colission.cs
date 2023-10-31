using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using System.Security.Cryptography;

public class Colission : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed = 3f;
    public float ySpeed = 3f;
    public TMP_Text scoreField;
    private int scoreLeft = 0;
    private int scoreRight = 0;
    public int scoreTop = 10;
    //Start is called before the first frame update
    private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        scoreField.text = scoreLeft + " - " + scoreRight;
        if (leftOrRight == "left")
        {
            xSpeed = 3f;
            ySpeed = 3f;

        }else if (leftOrRight == "right")
        {
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);       
    }
    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        if (scoreLeft >= scoreTop)
        {
            scoreField.text = "Right Player Has Won!";
            xSpeed = 0;
            ySpeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }else if (scoreRight >= scoreTop)
        {
            scoreField.text = "Left Player Has Won!";
            xSpeed = 0;
            ySpeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalwall"))
        {
            ySpeed = ySpeed * -1f;

        }else if (collision.gameObject.CompareTag("scoreLeft"))
        {
            scoreRight++;          
            resetBall("Left");
        }
        else if (collision.gameObject.CompareTag("scoreRight"))
        {
            scoreLeft++;
            resetBall("right");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed *= -1.1f;
        }
    }
}
        
       
        