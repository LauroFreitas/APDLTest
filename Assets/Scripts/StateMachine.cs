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
            Trigger1.SetActive(true);
}
        else if(id == 2)
        {
            fase2 = fase;
            Trigger2.SetActive(true);
        }
        else if (id == 3)
        {
            fase3 = fase;
            Trigger3.SetActive(true);
        }
        else if (id == 4)
        {
            fase4 = fase;
            Trigger4.SetActive(true);
        }
        else if (id == 5)
        {
            fase5 = fase;
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
    }
}
