using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarLanterna : MonoBehaviour
{
    public Animator animator;
    public Animator animator2;
    public GameObject lanterna;
    public GameObject emPosse;
    public float luz;
    public bool luzAtivada;
    private bool luzligada;
    public List<SetEvents> Events;
    public void Update()
    {
        if(emPosse.activeSelf == false) 
        {
            luzligada = false;
            lanterna.SetActive(false);
        }
        LanternaAnim();
    }
    public void Start()
    {
        luz = 160;
    }
    private void LanternaAnim()
    {
        if (emPosse.activeSelf == true) 
        {
            if (luzligada == false)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                   
                    luzligada = true;
                    animator.SetTrigger("Ligar");
                    animator2.SetTrigger("Ligar");
                    lanterna.SetActive(true);
                    StartCoroutine(DiminuirD());
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
        else 
        {
            luzligada = false;
        }
    }
    public IEnumerator DiminuirD()
    {
        if (luz > 0)
        {
            while (luzligada == true)
            {
                luz -= 10;
                yield return new WaitForSeconds(1);
              
                if (luz == 30 && Events[0].ID == 1)
                {
                    Events[0].Event.Invoke();//Pisca
                    Debug.Log("Piscou");
                }
                if (luz == 120 && Events[1].ID == 1)
                {
                    Events[1].Event.Invoke();
                    Debug.Log("100%");
                }
                if (luz == 80 && Events[2].ID == 1)
                {
                    Events[2].Event.Invoke();
                    Debug.Log("75%");
                }
                if (luz == 40 && Events[3].ID == 1)
                {
                    Events[3].Event.Invoke();
                    Debug.Log("50%");
                }
              
                if (luz == 0 &&  Events[4].ID == 1)
                {
                     Events[4].Event.Invoke();
                    Debug.Log("25%");
                    yield break;
                }
            }
        }
        else
        {
            Events[6].Event.Invoke();
            yield break;
        }
         
    }
}
