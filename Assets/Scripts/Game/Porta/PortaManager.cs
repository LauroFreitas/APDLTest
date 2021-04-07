using System.Collections;
using UnityEngine;

public delegate void DtPorta();
public class PortaManager : MonoBehaviour
{
    public static DtPorta dtPorta;
    public static PortaManager singleton;
    public ClassePorta[] portas = new ClassePorta[6];

    ClassePorta portaFinal1 = new ClassePorta(TypeDoor.chaveadas, false, "A");
    ClassePorta portaFinal2 = new ClassePorta(TypeDoor.chaveadas, false, "B");
    ClassePorta portaQPlayer = new ClassePorta(TypeDoor.nChaveada, true, "C");
    ClassePorta portaQPais = new ClassePorta(TypeDoor.nChaveada, false, "D");
    ClassePorta portaBanheiro1 = new ClassePorta(TypeDoor.nChaveada, false, "E");
    ClassePorta portaBanheiro = new ClassePorta(TypeDoor.nChaveada, false, "F");

    public GameObject portaPai;
    public GameObject pBFinal1;
    public GameObject pBFinal2;
    private GameObject pBQPlayer;
    private GameObject pBQPais;
    private GameObject pBBanheiro1;
    private GameObject pBBanheiro;

    public void Start()
    {
       pBQPlayer = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        pBQPais = gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
        pBBanheiro1 = gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject;
        pBBanheiro = gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject;

        portaFinal1.portaPrebab = pBFinal1;
        portaFinal2.portaPrebab = pBFinal2;
        portaQPlayer.portaPrebab = pBQPlayer;
        portaQPais.portaPrebab = pBQPais;
        portaBanheiro1.portaPrebab = pBBanheiro1;
        portaBanheiro.portaPrebab = pBBanheiro;

        portas[0] = portaFinal1;
        portas[1] = portaFinal2;
        portas[2] = portaQPlayer;
        portas[3] = portaQPais;
        portas[4] = portaBanheiro1;
        portas[5] = portaBanheiro;

        TrancarPorta();
        dtPorta += DestrancarPorta;
    }
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
    public void TrancarPortaF2() 
    {
       TrancarPorta();
    }
    public void TrancarPorta()
    {
        for (int i = 0; i < 6; i++)
        {
            if (portas[i].tipo == TypeDoor.chaveadas && portas[i].aberta == false)
            {
                portas[i].Desativar();
            }

            if (portas[i].tipo == TypeDoor.nChaveada && portas[i].aberta == false)
            {
                portas[i].Desativar();
            }
        }
    }
    public void DestrancarPorta()
    {
        for (int i = 0; i < 6; i++)
        {
            if (portas[i].tipo == TypeDoor.chaveadas)
            {
                portas[i].Ativar();
            }
        }

    }

}