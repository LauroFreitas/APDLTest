using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternaIten : Item
{

    public void Start()
    {
        estado = false;
        pMItem.SetActive(false);
    }
    public override void EventTriggerRay()
    {
        if (Input.GetKeyDown("e"))
        {
            if (estado == false)
            {
                pMItem.transform.SetParent(Player.singleton.playerPrefabMao.transform);//Chama a mão para a posição da chave
                //pMItem.SetActive(true);//Ativa a mão com a chave
                spriteItem.SetActive(true);//Ativa o sprite referente a chave
                spriteIteminventario.SetActive(true);//Ativa o sprite referente a chave
                estado = true;//Ativa o estado da chave (estado true quer dizer que ele etá com a chave)
                this.gameObject.SetActive(false);//destiva o gameobject;
            }
        }
    }
}
