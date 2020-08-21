using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;



public class Player : MonoBehaviour
{
    
    public GameObject ItensPai;
    public Camera cam;//area para camera 
    public GameObject TextViewEvermelho;
    public GameObject TextViewE;
    public GameObject playerPrefabMao;
    private Transform chave;
    private Transform lanterna;
   public void Start()
    {
        chave = ItensPai.transform.GetChild(0);
        lanterna = ItensPai.transform.GetChild(1);
    }
    public static Player singleton { get; set; } //criando singleton
    private void Awake()
    {
        NoDestroy();

    }
    void NoDestroy()//criando singleton
    {
        //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena
        DontDestroyOnLoad(gameObject);

        if (singleton == null && singleton != this)
        {
            singleton = this;

            //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        TextViewE.SetActive(false);
        TextViewEvermelho.SetActive(false);
        RayCast();
        TrocarItens();
    }
    public void TrocarItens()
    {
      

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (chave.GetComponent<ChaveIten>().estado == true)
            {
                chave.GetComponent<ChaveIten>().pMItem.SetActive(true);
                lanterna.GetComponent<LanternaIten>().pMItem.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (lanterna.GetComponent<LanternaIten>().estado == true)
            {
                chave.GetComponent<ChaveIten>().pMItem.SetActive(false);
                lanterna.GetComponent<LanternaIten>().pMItem.SetActive(true);
            }
        }
    }
    private void RayCast()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 20f)) //serve para pegar a posição do alvo e para a lanterna tb
        {
            var selection = hit.transform;

            if (selection.gameObject.GetComponent<Interagivel>() == true)
            {
                var interaction = selection.gameObject.GetComponent<Interagivel>();
                interaction.EventTriggerRay();
                TextViewE.SetActive(true);
            }
            else if (selection.gameObject.CompareTag("Porta"))
            {
                if (selection.gameObject.name == "PF2" && chave.GetComponent<ChaveIten>().estado == false) 
                {
                    TextViewEvermelho.SetActive(true);
                }
                else 
                {
                    TextViewE.SetActive(true);
                }
            }

        }

    }
    
    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.CompareTag("TriggerFase1"))
        {
            MetaEventSet.singleton.metaEvents[7].Event.Invoke();
            PortaManager.singleton.TrancarPortaF2();
            GameObject.Find("StateMachine").GetComponent<StateMachine>().SetFase(2);
          
        }

        if (_col.gameObject.CompareTag("TriggerFase2"))
        {
            MetaEventSet.singleton.metaEvents[8].Event.Invoke();
            PortaManager.singleton.TrancarPortaF2();
            GameObject.Find("StateMachine").GetComponent<StateMachine>().SetFase(3);

        }

        if (_col.gameObject.CompareTag("TriggerFase3"))
        {
            MetaEventSet.singleton.metaEvents[7].Event.Invoke();
            Debug.Log("Teste");
            PortaManager.singleton.TrancarPortaF2();
            GameObject.Find("StateMachine").GetComponent<StateMachine>().SetFase(4);
        }
    }

}
