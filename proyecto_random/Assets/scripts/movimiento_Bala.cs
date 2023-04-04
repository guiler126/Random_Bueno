using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_Bala : MonoBehaviour
{
    public float velocidad;
    public float tiempodevida;
    private SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, tiempodevida);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * velocidad);
    }
}
