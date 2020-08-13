using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gavetas : Interagivel
{
    public int Id;
    public override void EventTriggerRay()
    {
        if (Id == MetaEventSet.singleton.metaEvents[1].ID)
        {
            if (Input.GetKeyDown("e"))
            {
                MetaEventSet.singleton.metaEvents[1].Event.Invoke();
            }
        }
        else if (Id == MetaEventSet.singleton.metaEvents[0].ID)
        {
            if (Input.GetKeyDown("e"))
            {
                MetaEventSet.singleton.metaEvents[0].Event.Invoke();
            }
        }
        else if (Id == MetaEventSet.singleton.metaEvents[2].ID)
        {
            if (Input.GetKeyDown("e"))
            {
                MetaEventSet.singleton.metaEvents[2].Event.Invoke();
            }
        }
    }
}
