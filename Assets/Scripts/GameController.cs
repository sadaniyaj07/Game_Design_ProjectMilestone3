using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {FreeRoam, Dialog, Battle}

public class GameController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

   [SerializeField] PlayerController playerController;

   GameState state;

   private void Update()
   {
    if (state == GameState. FreeRoam)
     {
         playerController.HandleUpdate();
     } else if (state == GameState. Dialog)
     {
     }
       else if (state == GameState. Battle)
     {
     }
   }

     
}

