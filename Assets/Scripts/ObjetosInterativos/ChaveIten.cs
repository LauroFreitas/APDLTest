using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveIten : Item
{
 
    public void Start()
    {
        estado = false;//Player não está com a chave
        pMItem.SetActive(false);//Prefab da mão com a chave
    }
    public override void EventTriggerRay()//função do raycast presente no player
    {
        if (Input.GetKeyDown("e"))
        {
            // MetaEventSet.singleton.metaEvents[8].Event.Invoke();  
            if (estado == false)//Se o player não tem a posse da chave 
            {
                PortaManager.dtPorta.Invoke();//Destranca a porta
                pMItem.transform.SetParent(Player.singleton.playerPrefabMao.transform);//Chama a mão para a posição da chave
                //pMItem.SetActive(true);//Ativa a mão com a chave
                spriteItem.SetActive(true);//Ativa o sprite referente a chave
                estado = true;//Ativa o estado da chave (estado true quer dizer que ele etá com a chave)
                this.gameObject.SetActive(false);//destiva o gameobject
            }
        }
    }
    public void Estado(bool estad) 
    {
        estado = estad;
    }
}
