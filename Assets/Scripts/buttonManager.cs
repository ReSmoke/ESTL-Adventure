using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public bool iniciarDialogo = false;
    public GameObject jugador;
    private PlayerMovement player; 
    // Start is called before the first frame update
    void Start()
    {
        player = jugador.GetComponent<PlayerMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CambiarDialogo(){
        if(player.conversacion){
            iniciarDialogo=true;
            player.runSpeed=5;
        }
        else{iniciarDialogo=false;player.runSpeed=1;}

        
    
    }
  
   
}
