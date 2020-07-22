using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate void meuDelegate(Itens itens);
public enum ItensType
{
    chave,
    lanterna,
    remedio,
    pilha
}
public class ItensManager : MonoBehaviour
{
    public static ItensManager Singleton;
    public meuDelegate dtInvetario;

    public Chave chave = new Chave(ItensType.chave);
    public Lanterna lanterna = new Lanterna(ItensType.lanterna);

    private GameObject chavePrefab;
    private GameObject lanternaPrefab;

    public GameObject chave1;

    [SerializeField] public List<Itens> Iventario = new List<Itens>();//Invetario ainda n funcional

    private void Awake()
    {
        NoDestroy();

    }
    void NoDestroy()//criando singleton
    {
        //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena
        DontDestroyOnLoad(gameObject);

        if (Singleton == null && Singleton != this)
        {
            Singleton = this;

            //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        chavePrefab = gameObject.transform.GetChild(0).gameObject;//Pega o GameObject filho do ItensManager que é a chave
        //lanternaPrefab = gameObject.transform.GetChild(1).gameObject;//Pega o GameObject filho do ItensManager que é a chave
        chave.itemPrefab = chavePrefab;//Aparece na cena
        //lanterna.itemPrefab = lanternaPrefab;//Aparece na cena
        dtInvetario += AdicionarItens;
    }

    public void AdicionarItens(Itens item)
    {
        Debug.Log(item);
        Debug.Log(item.tipo);
        Debug.Log("dada");
        if (item.tipo == ItensType.chave)//Verifica o enum
        {
            Debug.Log("dadawww");
           
            chave.Pegar(chave1);//Desativa Prebaf
          
        }
        /*
        else if (item.tipo == ItensType.lanterna)//Verifica o enum
        {
            lanterna.Pegar(chave1);//Desativa Prebaf
        }
        */
        Iventario.Add(item); //Adiciona na list os itens
    }
   
    public void RemoverItens()
    {
        Iventario.Remove(chave);
    }

    public bool VerificarConteins()
    {
        bool a = Iventario.Contains(chave);
        return a;
    }
   
}
