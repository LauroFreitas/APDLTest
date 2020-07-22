using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class Player : MonoBehaviour
{
    private string RayCastChave = "Chave";//seleciona a tag Lanterna para o campo serial
   // private string RayCastLanterna = "Lanterna";//seleciona a tag Lanterna para o campo serial
   // private string RayCastTV = "TV";//seleciona a tag Lanterna para o campo serial
    private string RayCastPorta = "Porta";//seleciona a tag Lanterna para o campo serial
    public GameObject playerPrefab;
    public Camera cam;//area para camera 
    public GameObject TextView;
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
       RayCast();
    }


    private void RayCast() 
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 20f)) //serve para pegar a posição do alvo e para a lanterna tb
        {
            var selection = hit.transform;

            if (selection.CompareTag(RayCastChave))
            {
                TextView.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    AdicionarItem(ItensManager.Singleton.chave);
                    PortaManager.dtPorta.Invoke();
                }
            }
            else if (selection.CompareTag(RayCastPorta))
            {
                TextView.SetActive(true);
            }
            else
            {
                TextView.SetActive(false);
            }
            /*
            else if (selection.CompareTag(RayCastLanterna))
            {
                TextView.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    AdicionarItem(ItensManager.Singleton.lanterna);
                }
            }
            else if (selection.CompareTag(RayCastTV))
            {
                TextView.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    //MetaEventSet.singleton.metaEvents[7].Event.Invoke();
                }
            }
            else 
            {
                TextView.SetActive(false);
            }
            */
        }
        
    }
    private void AdicionarItem(Itens item) 
    {
        ItensManager.Singleton.dtInvetario.Invoke(item);
    }
}
