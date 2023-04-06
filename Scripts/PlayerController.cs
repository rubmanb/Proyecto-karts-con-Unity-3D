using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocitat;
    public float controlVelocitat;

    void Start()
    {
        Debug.Log("Iniciant el Player");
        controlVelocitat = 15f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //moviments simples avant i cap a darrere
        Vector3 direccioF = Vector3.forward;
        Vector3 direccioB = Vector3.back;
        velocitat = controlVelocitat * Time.deltaTime;

        if((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))){
            transform.Translate(direccioB * velocitat);
        }
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))){
            transform.Translate(direccioF * velocitat);
        }

        //rotació dreta i esquerra
        Vector3 eix = Vector3.up;
        float velocitatAngular = 5.5f * Time.deltaTime;

        if((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))){
            transform.Rotate(eix * 25.0f * Input.GetAxis("Horizontal") * velocitatAngular);
        }
        if((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))){
            transform.Rotate(eix * 25.0f * Input.GetAxis("Horizontal") * velocitatAngular);
        }

    }

    
}
