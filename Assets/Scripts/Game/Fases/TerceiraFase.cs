using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerceiraFase : MonoBehaviour
{
    public List<SetEvents> Events;
    public static SegundaFase a;
    public void TerceiraFaseEvent()
    {
        Debug.Log("A");
        if (Events[0].ID == 7)
        {
            Debug.Log("B");
            Events[0].Event.Invoke();
        }
        if (Events[1].ID == 7)
        {
            Debug.Log("C");
            Events[1].Event.Invoke();
        }
        if (Events[2].ID == 7)
        {
            Debug.Log("D");
            Events[2].Event.Invoke();
        }

    }
}
