using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogSccript : MonoBehaviour
{
    
    public TextMeshProUGUI dialogueText;
    public string[] lines;

    public float textSpeed  = 0.1f;

    public int index;
    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialog();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown(0)){
            NextLine();
        }
        else{
            StopAllCoroutines();
            dialogueText.text = lines[index];
        }
    }

    public void actualizar(){
         index=0;
         gameObject.SetActive(true);
        
    }

    public void StartDialog(){
        index = 0;
        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine(){
        foreach(char letter in lines[index].ToCharArray()){
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine(){
        if(index<lines.Length-1){
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else{
            gameObject.SetActive(false);
        }
    }
}
