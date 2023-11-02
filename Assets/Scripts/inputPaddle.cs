using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    //variables
    // handling speed for paddle
    public float speed = 3.0f;
    // it checks witch paddle it is (left or right) 
    public string leftOrRight;


    /// <summary>
    /// function that handles movement and has arguments for up and down keycode
    /// </summary>
    /// <param name="up">key that is handeling up input</param>
    /// <param name="down">key that is handeling down input</param>
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        // when up key is pressed and hold and the vertical position is under or the same as 3.4 it goes up
        if (Input.GetKey(up) && transform.position.y <= 3.4f)
        {
            //translate works with a new vector 3 and 
            // it's changing with a vector3.up multiplied with speed and Time.deltaTime
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        // works the same as up, only this time it goes down
        else if (Input.GetKey(down) && transform.position.y >= -3.2f)
        {
            //works same as up only uses vector3.down because of the direction
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        // change within Unity if it's left or right paddle
        if (leftOrRight == "Left")
        {
            //for the left paddle the command W is for going up and S for down
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }else if (leftOrRight == "Right")
        {
            //for the right tpaddle the command UpArrow is for going up and DownArrow for down
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
