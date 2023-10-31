using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UIElements;

public class Ball : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;   
  
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);      
    }

    // Update is called once per frame
    void Update()
    {
        Xposition = Xposition + 1f * Time.deltaTime;
        Yposition = Yposition + 1f * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);

    }
}
