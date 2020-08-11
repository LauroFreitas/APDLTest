using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilhas : Item
{
    public override void EventTriggerRay()
    {
        if (Input.GetKeyDown("e"))
        {
            this.gameObject.SetActive(false);
            EventManager.singleton.Events[7].Event.Invoke();
        }
    }

    
}
