using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject InvaderA;

    [SerializeField]
    GameObject InvaderB;

    [SerializeField]
    GameObject InvaderC;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;


    // Start is called before the first frame update
    void Awake()
    {
        float x = xMin;
        for (int I = 1; I <= nInvasores; I++)
        {
            GameObject newInvader = Instantiate(InvaderA, transform);
            newInvader.transform.position = new Vector3(x, -0.5f, 0f);
            x += 1f;
        }
        float x2 = xMin;
        for (int I = 1; I <= nInvasores; I++)
        {
            GameObject newInvader = Instantiate(InvaderB, transform);
            newInvader.transform.position = new Vector3(x2, 0.5f, 0f);
            x2 += 1f;
        }
        float x3 = xMin;
        for (int I = 1; I <= nInvasores; I++)
        {
            GameObject newInvader = Instantiate(InvaderC, transform);
            newInvader.transform.position = new Vector3(x3, 1.5f, 0f);
            x3 += 1f;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
