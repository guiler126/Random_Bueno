using System.Collections;

using UnityEngine;

public class Bala : MonoBehaviour
{
    public GameObject bala;
    public float timer;
    public int counter;
    public int maxCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisparaBalas());
    }

    // Update is called once per frame
    
    IEnumerator DisparaBalas()
    {
        Debug.Log("Dispara");
        for (int i = 0; i <maxCounter; i++)
        {
            counter++;
            Instantiate(bala, transform.position, transform.rotation);
            yield return new WaitForSeconds(timer);
        }
        Debug.Log("Deja de disparar");
    }
}
