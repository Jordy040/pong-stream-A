using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    public float yspeed = 3f;      
    public float yposition = 0;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        yposition = yposition + yspeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yposition, transform.position.z);
        
        if (yposition >= 3.4f)
        {
            yspeed = yspeed * -1f;
        }
        else if (yposition <= -3.2f)
        {
            yspeed = yspeed * -1f;
        }

        transform.position = new Vector3(transform.position.x, ball.transform.position.y / 2, transform.position.z);
    }
}
