using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    public float Xposition = -0.45f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;
    // Start is called before the first frame update
    void Start() 
    {
     //transform.position = new Vector3(Xposition, Yposition, 0);
     xSpeed = 1f;
     ySpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.CompareTag("horizontalwall")) 
            {
                ySpeed = ySpeed * -1f;
                Debug.Log("Touches horizontal wall");
            }
            else if (collision.gameObject.CompareTag("verticalwall"))
            {
                xSpeed = xSpeed * -1f;
                Debug.Log("Touches vertical wall");
            }
        }
}
