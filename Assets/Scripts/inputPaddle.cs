using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float speed = 3.0f;
    public string leftOrRight;


    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y <= 3.4f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -3.2f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "Left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }else if (leftOrRight == "Right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
