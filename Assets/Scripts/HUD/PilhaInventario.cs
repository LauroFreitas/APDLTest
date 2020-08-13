using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PilhaInventario : MonoBehaviour
{
    public static int quantidade;
    public GameObject ItemImagem;
    public GameObject text;
    public Text qText;
    public GameObject player;
    public void TEste() 
    { qText.enabled = true;
        if (ItemImagem.activeSelf == false)
        {
            text.SetActive(true);
            ItemImagem.SetActive(true);
        }
    }

    public void Update()
    {
        qText.text = quantidade.ToString() + " X";
    }
    public void UsePilha() 
    {
        if (quantidade >= 1) 
        {
            quantidade -= 1;
            player.GetComponent<LigarLanterna>().Events[5].Event.Invoke();
        }
    }
}
