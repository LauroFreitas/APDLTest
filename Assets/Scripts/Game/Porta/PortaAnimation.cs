using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAnimation : MonoBehaviour
{
    public Animator animator;
    public static PortaAnimation singleton;
    private bool colider;
    private bool PortaAberta;
    AudioSource source;
    AudioSource source1;
    public void Start()
    {
        source = FindObjectOfType<AudioManager>().sounds[4].source;
        source1 = FindObjectOfType<AudioManager>().sounds[5].source;
    }
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
                PlaySoundMove("PortaAbrir");
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) && colider)
            {
                PortaAberta = false;
                animator.SetTrigger("Fechar");
                PlaySoundMove("PortaFechar");
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
        PlaySoundMove("PortaFechar");
    }
    public void PlaySoundMove(string name)
    {
        FindObjectOfType<AudioManager>().Play(name);
    }
    public void Abrir()
    {
        PortaAberta = true;
        animator.SetTrigger("Abrir");
        PlaySoundMove("PortaAbrir");
    }
}