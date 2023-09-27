using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogNPC : MonoBehaviour
{
    public GameObject buttonManager;
    public GameObject player;

    public GameObject panel;
    // Start is called before the first frame update
    private buttonManager boton;
    private PlayerMovement jugador;

    private dialogSccript control;
    void Start()
    {
        boton= buttonManager.GetComponent<buttonManager>();
        jugador = player.GetComponent<PlayerMovement>();
        control = panel.GetComponent<dialogSccript>();
    }

    // Update is called once per frame
    void Update()
    {

       
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            control.actualizar();
        
          
            
       
        
    }

    private void OnTriggerExit2D(){
        control.index=0;
    }
}
