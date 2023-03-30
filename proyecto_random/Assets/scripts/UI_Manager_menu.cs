
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager_menu : MonoBehaviour
{
   public GameObject panel_pausa;
   

   public void play(string scene)
   {
      SceneManager.LoadScene(scene);
   }

   public void exit()
   {
      Application.Quit();
   }

   public void mostrarPausa()
   {
      if (Input.GetKey(KeyCode.P))
      {
       panel_pausa.SetActive(true);
         Time.timeScale = 0f;

         if (!panel_pausa.active)
         {
            Time.timeScale = 1f;
         }
      }
   }
}
