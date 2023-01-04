using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{

    //Variables de movimiento
    public float speed = 5f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
   
    

    void Start()
    {

    }




    void Update()
    {
        //Establecer teclas de movimiento y rotacion
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Establecer movimiento "adelante" y "atras"
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Establecer rotacion "izquierda" y "derecha"
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


        

        

    }
}
