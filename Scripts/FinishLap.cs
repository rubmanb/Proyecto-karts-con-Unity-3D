using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLap : MonoBehaviour
{
    public bool carreraFinalitzada;
    public int voltes = 0;
    // Start is called before the first frame update
    void Start()
    {
        carreraFinalitzada = false;
    }

    void OnCollisionEnter(Collision obj){
        print("Començem la carrera");
        print("Carrera Finalitzada: "+carreraFinalitzada);
        print("Numero de voltes actuals: "+voltes);
        
        if((voltes == 1) && (carreraFinalitzada == false)){
            carreraFinalitzada = true;
            print("Carrera Finalitzada: "+carreraFinalitzada);
        }
        if(obj.gameObject.tag == "liniaMeta"){
            voltes += 1;
            carreraFinalitzada = false;
        }
        
    }
}
