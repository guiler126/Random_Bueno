
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager_menu : MonoBehaviour
{
   public GameObject panel_pausa;
   
   public void Start()
   {
      Time.timeScale = 1f;
   }

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
      if (Input.GetKeyDown(KeyCode.Escape))
      {
      activar_pausa();
         Time.timeScale = 0f;
      }
      
      if (Input.GetKeyUp(KeyCode.Escape))
      {
         desactivar_pausa();
         Time.timeScale = 1f;
      }
   }

   public void activar_pausa()
   {
      panel_pausa.SetActive(true);
   }
   
   public void desactivar_pausa()
   {
      panel_pausa.SetActive(false);
   }
}
