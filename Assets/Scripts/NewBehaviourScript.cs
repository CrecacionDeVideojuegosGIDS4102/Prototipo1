using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Alumno: Espinoza Gómez Abraham Salvador

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 20;
    // Start is called before the first frame update
    // Update the position of the game object every frame based on its current position and the direction of movement (forward) multiplied by the time elapsed since the last frame.
    float inputY;
    float inputX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputY = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime*10*inputX);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*inputY);
    }
}
