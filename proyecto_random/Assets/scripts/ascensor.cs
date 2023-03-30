
using System;
using UnityEngine;

public class ascensor : MonoBehaviour
{

    public Transform[] point;

    private float waittime;

    public float startwaittime = 2;

    private int i = 0;
    
    public float Velocidad = 0.5f;

    

    // Start is called before the first frame update
    void Start()
    {
        waittime = startwaittime;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, point[i].transform.position, Velocidad * Time.deltaTime);

        if (Vector2.Distance(transform.position, point[i].transform.position) < 0.1f)
        {
            if (waittime <= 0)
            {
                if (point[i]    != point[point.Length -1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }

                waittime = startwaittime;
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        col.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        col.collider.transform.SetParent(null);
    }
}
