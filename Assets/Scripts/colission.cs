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
    
// Settings for the ball
    //- Move in x and y direction
    //- Change course when it collide whit a wall or paddle
    //- when ball hits a paddle increase speed
    //- Scoring when ball hits left or right wall
    //- showing score in a text field
    
  
    //<variables>
    //- horizontal and vertical Position 
    public float Xposition = 0f;
    public float Yposition = 0f;

    //- horizontal and vertical speed
    public float xSpeed = 3f;
    public float ySpeed = 3f;
    //- store baseline speed for reset function
    private float baseLineSpeed;

    //- reference to textobject (Has to be linked in unity)
    public TMP_Text scoreField;

    //- Keeping left and right score 
    private int scoreLeft = 0;
    private int scoreRight = 0;

    //- if the score hits the number it stops the game 
    public int scoreTop = 10;
    

    // function for the resets the ball to start position and adds score to left or right
    private void resetBall(string leftOrRight)
    {
        //starting position for X and Y
        Xposition = 0f;
        Yposition = 0f;
        //displays left and right score in text field
        scoreField.text = scoreLeft + " - " + scoreRight;

        //checks argument "leftOrRight" from the function if left or right is typed in
        if (leftOrRight == "left")
        {
            //ball goes right and up
            xSpeed = baseLineSpeed;
            ySpeed = baseLineSpeed;

        }else if (leftOrRight == "right")
        {
            //ball goes left and up
            xSpeed = -baseLineSpeed;
            ySpeed = baseLineSpeed;
        }
    }
    // start is called before the first frame update
    void Start()
    {
        //set baseline speed 
        baseLineSpeed = xSpeed;

        // Set starting x and y position for the ball
        transform.position = new Vector3(Xposition, Yposition, 0);       
    }   

    //update is called once per framee 
    void Update()
    {
        // updates the x and y position with xSpeed and ySpeed multiplied with Time.deltaTime
        // Time.deltaTime makes it so the ball is moving on actual time and not frame rate so speed is same on every device
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;

        //updates the position with new values
        transform.position = new Vector3(Xposition, Yposition, 0);

        // checks of left or right score value is equal or bigger than the topscore
        // If it's met it stops the ball and sets the ball in the middle
        // show in text field witch player has won
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
    // If it hit a gameobject with a collider(2D) and that one is set to a trigger it does something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if gameobject has a tag that is called "horizontalwall" 
        // and it has a collider on it set to trigger..       
        if (collision.gameObject.CompareTag("horizontalwall"))
        {
            //flips direction vertical from up to down
            ySpeed = ySpeed * -1f;
      
        }else if (collision.gameObject.CompareTag("scoreLeft"))
        {
            // adds 1 to the right score and triggers the reset function with left argument
            scoreRight++;          
            resetBall("Left");
        }
        else if (collision.gameObject.CompareTag("scoreRight"))
        {
            // adds 1 to the left score and triggers the reset function with right argument
            scoreLeft++;
            resetBall("right");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            // if it hits a paddle it flips the horizontal direction and i
            xSpeed *= -1.1f;
        }
    }
}
        
       
        