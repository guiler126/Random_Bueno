
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_manager : MonoBehaviour
{
    public static UI_manager instance;
    public GameObject menu_opciones;
    public GameObject menu_inicio;
    public GameObject menu_dificultad;

    public void Awake()
    {
        instance = this;
    }

    public void play(string scena)
    {
        SceneManager.LoadScene(scena);
    }

    public void opciones()
    {
        menu_opciones.SetActive(true);
        menu_inicio.SetActive(false);
    }
    
    
    public void opcionesJuego()
    {
        menu_opciones.SetActive(true);
        Time.timeScale = 0f;
    }

    public void volver()
    {
        menu_opciones.SetActive(false);
        menu_inicio.SetActive(true);
        menu_dificultad.SetActive(false);
    }
    
    public void volverJuego()
    {
        menu_opciones.SetActive(false);
        Time.timeScale = 1f;
    }

    public void salir()
    {
        Application.Quit();
    }
}
