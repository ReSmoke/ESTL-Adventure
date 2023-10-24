using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stairs : MonoBehaviour
{
    string subiEscaleras;
    public Transform nuevaPosicion; 
    

    void Start(){
        subiEscaleras=SceneManager.GetActiveScene().name;
      
        if(subiEscaleras=="escena1"){
            nuevaPosicion.position=new Vector3(-22.0f,-20.0f,0.0f);
         }
         else if(subiEscaleras=="escena2"){
            nuevaPosicion.position=new Vector3(-65.0f,23.0f,0.0f);
         }
         else if(subiEscaleras=="escena3"){
            nuevaPosicion.position=new Vector3(-64.0f,31.0f,0.0f);
         }
         
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(subiEscaleras=="escena1"){
            SceneManager.LoadScene("escena2");
        }
         if(subiEscaleras=="escena2"){
            SceneManager.LoadScene("escena3");
        }
        if(subiEscaleras=="escena3"){
            SceneManager.LoadScene("escena2");
        }
          
     }
    
}
