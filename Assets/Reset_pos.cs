using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_pos : MonoBehaviour
{
    Vector3 orgpos;

    void Start()
    {
        orgpos=transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("WALL"))
        {
            transform.localPosition=orgpos;
        }

        else if(other.gameObject.CompareTag("WALL 2"))
        {
           transform.localPosition=orgpos;
        }

        else if(other.gameObject.CompareTag("WALL 3"))
        {
           transform.localPosition=orgpos;
        }
    }
}
