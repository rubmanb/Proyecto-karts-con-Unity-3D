using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpoints : MonoBehaviour
{
    
    //int contadorCheckpoints;

    private void OnTriggerEnter(Collider obj){
        /*if (obj.TryGetComponent<KartPlayer>(out KartPlayer kartplayer)){
            Debug.Log("CheckPoint!");
        }*/
        Debug.Log("CheckPoint"+ obj.transform.name);
        //contadorCheckpoints += 1;
        //Debug.Log("Numero de checkpoints atravessats: "+contadorCheckpoints);


    }
}
