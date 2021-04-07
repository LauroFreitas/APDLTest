using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirGaveta : MonoBehaviour
{
    public bool aberta;
    public Animator animacao;
    private void Start()
    {
        aberta = false;
    }
    
    public void Animar() 
    {
        if (aberta == false) 
        {
            Abrir();
            aberta = true;
        }
        else 
        {
            Fechar();
        }
    }
    public void Abrir()
    {
        animacao.SetTrigger("Abrir");
        aberta = true;
    }
    public void Fechar()
    {
        animacao.SetTrigger("Fechar");
        aberta = false;
    }
}
 