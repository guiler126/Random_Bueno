using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brillo : MonoBehaviour
{
    public Slider slider;
    public float slidervalue;
    public Image panelBrillo;
    
   
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slidervalue);
    }

    

    public void Sliderbirllo(float valor)
    {
        slidervalue = valor;
        PlayerPrefs.SetFloat("brillo", slidervalue);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slidervalue);
    }
}
