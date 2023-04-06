using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    
    public Vector3 offset;
    public Transform player;


    
    void Start()
    {
        player = GameObject.Find("KartPlayer").transform;    
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;
        offset = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 0.28f, Vector3.up)*offset;
        transform.LookAt(player);

        


    }
}
