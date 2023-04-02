using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class calidad : MonoBehaviour
{
    public TMP_Dropdown Dropdown;
    public int Calidad;
    void Start()
    {
        Calidad = PlayerPrefs.GetInt("numeroDeCalidad", 3);
        Dropdown.value = Calidad;
        AjustarCalidad();
    }

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(Dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", Dropdown.value);
        Calidad = Dropdown.value;
    }

   
}
