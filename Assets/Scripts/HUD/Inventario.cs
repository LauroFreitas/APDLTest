using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public GameObject Invent;
    public List<SetEvents> Events;
    public GameObject player;
    private void Update()
    {
        if (Invent.activeSelf == false)
        {
            if (Input.GetKeyDown("i"))
            {
                Invent.SetActive(true);
                if (Events[0].ID == 4)
                {
                    Events[0].Event.Invoke();
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        }
        else 
        {
            if (Input.GetKeyDown("i"))
            {
                Invent.SetActive(false);
                if (Events[1].ID == 4)
                {
                    Events[1].Event.Invoke();
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }
        }
    }
}
