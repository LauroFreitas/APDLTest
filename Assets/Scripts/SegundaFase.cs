using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundaFase : MonoBehaviour
{
    public List<SetEvents> Events;
    public static SegundaFase a;
    public void PrimeiraFaseEvent()
    {
        if (Events[0].ID == 3)
        {
            Events[0].Event.Invoke();
        }
        if (Events[1].ID == 3)
        {
            Events[1].Event.Invoke();
        }
       
    }
}
