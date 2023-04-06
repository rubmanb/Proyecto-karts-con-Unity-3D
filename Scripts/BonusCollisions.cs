using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusCollisions : MonoBehaviour
{
    // Start is called before the first frame update

    public int aumentarPunts = 0;
    public int puntsTotals;
    public string puntsActuals;
    int bonusRandom;
    //public GameObject PuntuacioBox;
    public string[] bonus = new string[]{"puntsExtra", "aumentarVelocitat", "disminuirVelocitat"};

    public GameObject PuntuacioBox;
    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "BonusBox"){
            Destroy(other.gameObject);
            bonusRandom = Random.Range(0,3);
            Transform player = GameObject.Find("KartPlayer").transform;
            print(bonusRandom);
            switch (bonus[bonusRandom]){
                case "puntsExtra":
                    aumentarPunts += 10;
                    puntsTotals += aumentarPunts;
                    break;
                case "aumentarVelocitat":
                    player.GetComponent<PlayerController>().controlVelocitat += 5;
                    Debug.Log("Velocitat aumentada");
                    break;
                case "disminurVelocitat":
                    player.GetComponent<PlayerController>().controlVelocitat -= 5;
                    Debug.Log("Velocitat disminuida");
                    break;
                default:
                    print("Error en el switch del bonus");
                    break;
                
            }
            print("Has obtés "+puntsTotals+ "Punts");
        }
    }

    void Update(){
        puntsActuals = puntsTotals.ToString("F0");
        PuntuacioBox.GetComponent<Text>().text = "" + puntsActuals;
    }

  
}
