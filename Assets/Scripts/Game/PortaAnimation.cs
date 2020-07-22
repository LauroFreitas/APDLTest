using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAnimation : MonoBehaviour
{
    public Animator animator;
    public static PortaAnimation singleton;
    private bool colider;
    private bool PortaAberta;

    public void Update()
    {
        OnAbriPorta();
    }
    private void OnAbriPorta()
    {
        if (PortaAberta == false)
        {
            if (Input.GetKeyDown(KeyCode.E) && colider)
            {
                PortaAberta = true;
                animator.SetTrigger("Abrir");
               
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) && colider)
            {
                PortaAberta = false;
                animator.SetTrigger("Fechar");
            }
        }
    }
    void OnTriggerStay(Collider _col)
    {
        if (_col.gameObject.CompareTag("Player"))
        {
            colider = true;
        }
    }
   
    void OnTriggerExit(Collider _col)
    {
        if (_col.gameObject.CompareTag("Player"))
        {
            colider = false;
        }
    }

    public void Fechar()
    {
        PortaAberta = false;
        animator.SetTrigger("Fechar");
    }

    public void Abrir()
    {
        PortaAberta = true;
        animator.SetTrigger("Abrir");
    }
}