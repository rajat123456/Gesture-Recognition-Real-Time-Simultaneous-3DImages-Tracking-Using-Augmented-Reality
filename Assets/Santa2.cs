using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa2 : MonoBehaviour
{
    public Vector3 another;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(another*Time.deltaTime);
    }
}
