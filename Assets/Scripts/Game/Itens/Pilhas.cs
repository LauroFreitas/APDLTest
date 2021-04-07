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
            spriteIteminventario.SetActive(true);
            PilhaInventario.quantidade += 1;
        }
    }

    
}
