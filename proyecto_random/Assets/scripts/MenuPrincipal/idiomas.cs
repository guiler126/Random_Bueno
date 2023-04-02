using System.Collections;
using System.Collections.Generic;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine;

public class idiomas : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.HasKey("idioma_guardado"))
        {
            StartCoroutine("cambiarIdioma");
        }
        
       
    }

    public void SetLenguage(string newLanguageCode)
    {
        Dictionary<string, Locale> LanguageDic = new Dictionary<string, Locale>
        {
            {"en", LocalizationSettings.AvailableLocales.Locales[0]},
            {"fr", LocalizationSettings.AvailableLocales.Locales[1]},
            {"de", LocalizationSettings.AvailableLocales.Locales[2]},
            {"ru", LocalizationSettings.AvailableLocales.Locales[3]},
            {"es", LocalizationSettings.AvailableLocales.Locales[4]}
        };

        if (LanguageDic.ContainsKey(newLanguageCode))
        {
            LocalizationSettings.SelectedLocale = LanguageDic[newLanguageCode];
            PlayerPrefs.SetString("idioma_guardado", newLanguageCode);


        }
    }

    IEnumerator cambiarIdioma()
    {
        yield return new WaitForSeconds(0.5f);
        SetLenguage(PlayerPrefs.GetString("idioma_guardado"));
    }
}

