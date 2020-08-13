using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiraFase : MonoBehaviour
{
    public List<SetEvents> Events;
   // public GameObject fase2;
    public void Start()
    {
        PrimeiraFaseEvent();
    }

    public void PrimeiraFaseEvent ()
    {
        if (Events[0].ID == 2)
        {
            Events[0].Event.Invoke();
        }
        if (Events[1].ID == 2)
        {
            Events[1].Event.Invoke();
        }
        if (Events[2].ID == 2)
        {
            Events[2].Event.Invoke();
        }
    }

}
