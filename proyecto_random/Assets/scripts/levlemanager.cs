using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levlemanager : MonoBehaviour
{
    public GameObject camara;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && !col.isTrigger)
        {
            camara.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player") && !col.isTrigger)
        {
            camara.SetActive(false);
        }
    }
}
