using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class RemedioInventari : MonoBehaviour
{
    public static int quantidade;
    public GameObject ItemImagem;
    public GameObject text;
    public Text qText;
    public GameObject player;
    public void TEste()
    {
        qText.enabled = true;
        if (ItemImagem.activeSelf == false)
        {
            text.SetActive(true);
            ItemImagem.SetActive(true);
        }
    }
    public void Desativar()
    {
        qText.enabled = false;
        if (ItemImagem.activeSelf == true)
        {
            text.SetActive(false);
            ItemImagem.SetActive(false);
        }
    }
    public void Update()
    {
        qText.text = quantidade.ToString() + " X";
    }
    public void UseRemedio()
    {
        if (ItemImagem.activeSelf == true) 
        {
            if (quantidade >= 1)
            {
                quantidade -= 1;
                var estabilidade = player.GetComponent<BarraEstabilidade>();
                estabilidade.AumentarEstabilidade();
            }
        }
      
    }
}
