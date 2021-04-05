using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    [SerializeField]
    GameObject fire;

    //[SerializeField]
    //float cadencia = 1.5f;


    public float BaseFireWaitTime = 3.0f;
    public float minFireRateTime = 1.0f;
    public float maxFireRateTime = 3.0f;

    [SerializeField]
    float vidasImortal = 10f;

    private void Start()
    {
        BaseFireWaitTime = BaseFireWaitTime + Random.Range(minFireRateTime, maxFireRateTime);
    }

    private void FixedUpdate()
    {
        if (tag == "Destructivel")
        {
            if (Time.time > BaseFireWaitTime)
            {
                BaseFireWaitTime = BaseFireWaitTime + Random.Range(minFireRateTime, maxFireRateTime);
                Instantiate(fire, transform.position, Quaternion.identity);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Imortal")
        {
            if (collision.gameObject.tag == "FogoAmigo")
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }else
        {
            vidasImortal -= 1;
            if (vidasImortal < 1)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
    }




}

    

