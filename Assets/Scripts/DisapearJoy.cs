using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearJoy : MonoBehaviour
{
   public void dissapear(){
    gameObject.SetActive(false);
   }
   public void appear(){
    gameObject.SetActive(true);
   }
}
