using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{

    public bool fase1;
    public bool fase2;
    public bool fase3;
    public bool fase4;
    public bool fase5;
    public int faseAtual;

    public GameObject Trigger1;
    public GameObject Trigger2;
    public GameObject Trigger3;
    public GameObject Trigger4;
    public GameObject Trigger5;

    public void SetFase(int id) 
    {
        bool fase = true;
        if (id == 1) 
        {

            fase1 = fase;
            faseAtual = id;
            Trigger1.SetActive(true);
}
        else if(id == 2)
        {
            fase2 = fase;
            faseAtual = id;
            Trigger2.SetActive(true);
        }
        else if (id == 3)
        {
            fase3 = fase;
            faseAtual = id;
            Trigger3.SetActive(true);
        }
        else if (id == 4)
        {
            fase4 = fase;
            faseAtual = id;
            Trigger4.SetActive(true);
        }
        else if (id == 5)
        {
            fase5 = fase;
            faseAtual = id;
            Trigger5.SetActive(true);
        }
    }
    public void Update()
    {
        if (fase2 == true)
        {
            fase1 = false;
            Trigger1.SetActive(false);
        }
        if (fase3 == true)
        {
            fase2= false;
            Trigger2.SetActive(false);
        }
        if (fase4 == true)
        {
            fase3 = false;
            Trigger3.SetActive(false);
        }
    }
}
