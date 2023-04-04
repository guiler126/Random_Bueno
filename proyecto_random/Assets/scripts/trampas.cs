using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampas : MonoBehaviour
{
    public GameObject respawn;
    public GameObject player;
    public Animator PlayerAnimator;
    private SoundManager soundManager;
    
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
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
