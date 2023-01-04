using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -7);

    private Vector3 offset1p = new Vector3(-0.23f, 2, 1);

    private Vector3 camara = new Vector3(0, 5, -7);


    public int speed = 125;

    float horizontalInput;

    bool cam = true;

    

    void Start()
    {
       
        
    }

    private void Update()
    {

        if (Input.GetKeyDown("o") && cam == true)
        {
            cam = false;
            camara = offset1p;
            transform.rotation = player.transform.rotation;



        }
        else if (Input.GetKeyDown("o") && cam == false)
        {
            cam = true;
            camara = offset;
            transform.rotation = Quaternion.Euler(8, 0, 0);

        }


    }


    void LateUpdate()
    {
        

        horizontalInput = Input.GetAxis("Horizontal");

        transform.position = player.transform.position + camara;
        if (cam == false)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * speed * horizontalInput);

        }


    }

    private void FixedUpdate()
    {

       
    }
}
