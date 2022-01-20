using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Multiple_VB : MonoBehaviour
{

    public GameObject btn1, btn2, btn3;

    VirtualButtonBehaviour[]vrb;
    void Start()
    {
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);

        vrb=GetComponentsInChildren<VirtualButtonBehaviour>();
        
        for(int q=0;q<vrb.Length;q++)
        {
            vrb[q].RegisterOnButtonPressed(onButtonPressed);
            vrb[q].RegisterOnButtonReleased(onButtonReleased);
        }
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName=="Button1")
        {
            btn1.SetActive(true);
            btn2.SetActive(false);
            btn3.SetActive(false);
        }

        else if(vb.VirtualButtonName=="Button2")
        {
            btn1.SetActive(false);
            btn2.SetActive(true);
            btn3.SetActive(false);
        }

        else if(vb.VirtualButtonName=="Button3")
        {
            btn1.SetActive(false);
            btn2.SetActive(false);
            btn3.SetActive(true);
        }

        else
        {
            throw new UnityException(vb.VirtualButtonName+"Virtual Button Not Supported");
        }

    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    }
}
