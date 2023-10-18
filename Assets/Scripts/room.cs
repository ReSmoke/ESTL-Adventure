using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class room : MonoBehaviour
{
    public GameObject paredActual;

    public GameObject nombreAula;
    public TextMeshProUGUI dialogueText;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        paredActual.SetActive(true);
        nombreAula.SetActive(true);
        dialogueText.text=paredActual.name;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Invoke("byeWalls",3f);
        Invoke("byeText",3f);
    }

    private void byeText(){
        nombreAula.SetActive(false);
    }

     private void byeWalls(){
        paredActual.SetActive(false);
    }
 
 
    // Start is called before the first frame update
}
