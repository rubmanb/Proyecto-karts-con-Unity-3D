using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBonusBox : MonoBehaviour
{
    float rotacio;
    
    // Update is called once per frame
    void Update()
    {
        rotacio += Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(20,rotacio,60);
    }
}
