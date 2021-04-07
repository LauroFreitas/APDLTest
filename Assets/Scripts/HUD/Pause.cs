using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseHUd;
    public List<SetEvents> Events;
    public GameObject player;
    private void Update()
    {
        if (pauseHUd.activeSelf == false)
        {
            if (Input.GetKeyDown("p"))
            {
                pauseHUd.SetActive(true);
                if (Events[0].ID == 6)
                {
                    Events[0].Event.Invoke();
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        }
    }
    public void Despausar()
    {
        pauseHUd.SetActive(false);
        if (Events[1].ID == 6)
        {
            Events[1].Event.Invoke();
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
