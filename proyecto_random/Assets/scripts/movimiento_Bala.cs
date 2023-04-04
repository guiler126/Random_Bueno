using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_Bala : MonoBehaviour
{
    public float velocidad;
    public float tiempodevida;
    public GameObject respawn;
    public GameObject player;
    public Animator PlayerAnimator;
    private SoundManager soundManager;
   
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    
    void Start()
    {
       Destroy(gameObject, tiempodevida);
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * velocidad);
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            PlayerAnimator.SetTrigger("die");
            soundManager.SeleccionAudio(2,0.2f);

            StartCoroutine(renacer());

        }
    }

    IEnumerator renacer()
    {

        yield return new WaitForSeconds(1f);
        
        player.transform.position = respawn.transform.position;  
    }
}
