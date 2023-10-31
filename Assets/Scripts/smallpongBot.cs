using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallpongBot : MonoBehaviour
{
    public float yspeed = 5f;      
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
        
        if (yposition >= 4.1f)
        {
            yspeed = yspeed * -1f;
        }
        else if (yposition <= -4.1f)
        {
            yspeed = yspeed * -1f;
        }

        transform.position = new Vector3(transform.position.x, ball.transform.position.y / 2, transform.position.z);
    }
}
