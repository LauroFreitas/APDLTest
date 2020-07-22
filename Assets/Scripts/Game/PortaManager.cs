using System.Collections;
using UnityEngine;

public delegate void DtPorta();
public class PortaManager : MonoBehaviour
{
    public static DtPorta dtPorta;
    public static PortaManager singleton;
    ClassePorta[] portas = new ClassePorta[6];

    ClassePorta portaFinal1 = new ClassePorta(TypeDoor.chaveadas, false, "A");
    ClassePorta portaFinal2 = new ClassePorta(TypeDoor.nChaveada, true, "B");
    ClassePorta portaQPlayer = new ClassePorta(TypeDoor.nChaveada, true, "C");
    ClassePorta portaQPais = new ClassePorta(TypeDoor.nChaveada, true, "D");
    ClassePorta portaSala = new ClassePorta(TypeDoor.nChaveada, true, "E");
    ClassePorta portaBanheiro = new ClassePorta(TypeDoor.nChaveada, true, "F");

    public GameObject portaPai;
    private GameObject pBFinal1;
    private GameObject pBFinal2;
    private GameObject pBQPlayer;
    private GameObject pBQPais;
    private GameObject pBSala;
    private GameObject pBBanheiro;

    public void Start()
    {
        pBFinal1 = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        pBFinal2 = gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
        pBQPlayer = gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject;
        pBQPais = gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject;
        pBSala = gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject;
        pBBanheiro = gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject;

        portaFinal1.portaPrebab = pBFinal1;
        portaFinal2.portaPrebab = pBFinal2;
        portaQPlayer.portaPrebab = pBQPlayer;
        portaQPais.portaPrebab = pBQPais;
        portaSala.portaPrebab = pBSala;
        portaBanheiro.portaPrebab = pBBanheiro;

        portas[0] = portaFinal1;
        portas[1] = portaFinal2;
        portas[2] = portaQPlayer;
        portas[3] = portaQPais;
        portas[4] = portaSala;
        portas[5] = portaBanheiro;

        TrancarPorta();
        dtPorta += DestrancarPorta;
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
            if (portas[i].tipo == TypeDoor.chaveadas && ItensManager.Singleton.VerificarConteins() == true)
            {
                portas[i].Ativar();
            }
        }

    }

}