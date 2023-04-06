using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLaps : MonoBehaviour
{
    public int contadorSegons;
    public int contadorMinuts;
    public float contadorMilisegons;
    public string contadorTemps;
    public GameObject SegonsBox;
    public GameObject MinutsBox;
    public GameObject MilisegonsBox; 
    
    public void Update(){
        contadorMilisegons += Time.deltaTime * 10;
        contadorTemps = contadorMilisegons.ToString("F0");
        MilisegonsBox.GetComponent<Text>().text = "" + contadorTemps;
        

        if (contadorMilisegons >= 10){
            contadorMilisegons = 0;
            contadorSegons += 1;
        }

        if(contadorSegons <= 9){
            SegonsBox.GetComponent<Text>().text = "0" + contadorSegons + ".";
        }else{
            SegonsBox.GetComponent<Text>().text = "" + contadorSegons + ".";
        }

        if(contadorSegons >= 60){
            contadorSegons = 0;
            contadorMinuts += 1;
        }

        if(contadorMinuts<=9){
            MinutsBox.GetComponent<Text>().text = "0" + contadorMinuts + ":";
        }else{
            MinutsBox.GetComponent<Text>().text = "" + contadorMinuts + ":";
        }
    }
}
