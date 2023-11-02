using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    //variables
    // vertical speed 
    public float yspeed = 3f;     
    // vertical starting position 
    private float yposition = 0;

    // Update is called once per frame
    void Update()
    {
        // it updates the y position with ySpeed multiplied by Time.deltaTime for realtime movement for the right paddle
        // Time.deltaTime makes it so the ball is moving on actual time and not frame rate so speed is same on every device
        yposition = yposition + yspeed * Time.deltaTime;

        // updates the position with new values
        // the transform.position.x defines to the bot paddle so it cant move to the left or right
        // x position is handeld with the current x position (transform.position.x)
        // the transform.position.z defines to the bot paddle so it cant move back or to the front
        // for z it doesnt matter its in 2d
        // the yposition makes it so the bot paddle tracks where the ball is and goes to the ball so it hits the ball everytime
        transform.position = new Vector3(transform.position.x, yposition, transform.position.z);
        
        // checks if the bot paddle goes over 3.4 vertical or is at 3.4
        // when it hits 3.4 it stops the bot paddle and makes it stop from going up
        if (yposition >= 3.4f)
        {
            //flips direction vertical from up to down
            yspeed = yspeed * -1f;
        }
        // checks if the bot paddle goes under -3.4 vertical or is at -3.4
        // when it hits -3.4 it stops the bot paddle and makes it stop from going down
        else if (yposition <= -3.2f)
        {
            //flips direction vertical from up to down
            yspeed = yspeed * -1f;
        }    
    }
}
