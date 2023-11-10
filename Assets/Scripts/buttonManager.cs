using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
   
    public GameObject jugador;
    public GameObject panel;
    public GameObject CanvasJoysticks;


    private PlayerMovement player; 
    private dialogSccript control;
    private DisapearJoy joy;
    
    // Start is called before the first frame update
    void Start()
    {
        joy = CanvasJoysticks.GetComponent<DisapearJoy>();
        player = jugador.GetComponent<PlayerMovement>();
        control = panel.GetComponent<dialogSccript>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CambiarDialogo(){
        
        if(player.conversacion){

            control.actualizar();
            joy.dissapear();
            
        }
        else{}

    }
  
   
}
