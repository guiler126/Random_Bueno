
using UnityEngine;

public class herreria : MonoBehaviour
{
   public GameObject panel_herreria;

   public void OnTriggerEnter2D(Collider2D col)
   {
      if (col.CompareTag("Player"))
      {
         panel_herreria.SetActive(true);
      }
   }

   public void OnTriggerExit2D(Collider2D other)
   {
      if (other.CompareTag("Player"))
      {
         panel_herreria.SetActive(false);
      }
   }
}
