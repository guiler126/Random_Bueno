
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

   public void Update()
   {
      if (Input.GetKey(KeyCode.Escape))
      {
       panel_pausa.active = !panel_pausa.active;
         Time.timeScale = 0f;

         if (!panel_pausa.active)
         {
            Time.timeScale = 1f;
         }
      }
   }
}
