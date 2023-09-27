using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogNPC : MonoBehaviour
{

    public string[] lines;
    public GameObject panel;
    


    private dialogSccript control;
   
    void Start()
    {
        
        control = panel.GetComponent<dialogSccript>();
    }

    // Update is called once per frame
    void Update()
    {

       
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            control.lines=lines;
        
    }

    private void OnTriggerExit2D(){
        control.index=0;
        
    }
}
