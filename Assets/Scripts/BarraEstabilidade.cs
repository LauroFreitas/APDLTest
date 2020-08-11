using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraEstabilidade : MonoBehaviour
{
    public int estabilidade;
    public int estabilidadeMax;
    private float timelimit = 10f;
    private float timer = 0;
    public GameObject imagem;

    public void Start()
    {
        estabilidade = 720;
        estabilidadeMax = 400;
    }
    private void Update()
    {
        timer += Time.deltaTime;//delta
        
        if (timer >= timelimit)
        {
            Vector3 teste = new Vector2(16, 0);
            timer = 0;
            estabilidade -= 16;
            imagem.transform.localScale -= teste;
        }

    }

    public void AumentarEstabilidade() 
    {
        int media = estabilidade / 2;
        Vector3 teste = new Vector2(media, 0);
        Vector3 teste2 = new Vector3(720, 1,1);
        imagem.transform.localScale += teste;
        if (imagem.transform.localScale.x >= 720) 
        {
            imagem.transform.localScale = teste2;
        }
    }
}
