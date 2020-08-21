using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remedios :Item
{
    public override void EventTriggerRay()
    {
        if (Input.GetKeyDown("e"))
        {
            this.gameObject.SetActive(false);
            spriteIteminventario.SetActive(true);
            RemedioInventari.quantidade += 1;
        }
    }
}
