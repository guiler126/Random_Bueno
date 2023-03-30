
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene("scenafinal");
        }
    }

    
}
