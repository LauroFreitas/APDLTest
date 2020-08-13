using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janela : Interagivel
{
    bool b = false;
    float a = 1;
    public override void EventTriggerRay()
    {
        if (Input.GetKey("e"))
        {
           // TextView.SetActive(true);

            if (Input.GetKey("e"))
            {
                a++;
            }
            if (Input.GetKey("e") == false)
            {
                a = 0;
            }
            else if (a >= 100)
            {
                MetaEventSet.singleton.metaEvents[3].Event.Invoke();
                a = 0;
                b = true;
            }
            if (Input.GetKeyDown("e") && b == true)
            {
                MetaEventSet.singleton.metaEvents[4].Event.Invoke();
                a = 0;
                b = false;
            }
        }
    }
}
