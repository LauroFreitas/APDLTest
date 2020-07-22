using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarLanterna : MonoBehaviour
{
    public Animator animator;
    public Animator animator2;
    public GameObject lanterna;
    private bool luzligada;
    

    public void Update()
    {
        LanternaAnim();
    }
    private void LanternaAnim()
    {
        if (luzligada == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                luzligada = true;
                animator.SetTrigger("Ligar");
                animator2.SetTrigger("Ligar");
                lanterna.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                luzligada = false;
                animator.SetTrigger("Desligar");
                animator2.SetTrigger("Desligar");
                lanterna.SetActive(false);

            }
        }
    }
}
