using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColideEventCorredor : MonoBehaviour
{
    GameObject statemachine;
    int fase; 
    public void Start()
    {
        statemachine = GameObject.Find("StateMachine");

    }
    private void OnTriggerEnter(Collider other)
    {
        var faseAtual = statemachine.GetComponent<StateMachine>();
        fase = faseAtual.faseAtual;
        if (other.gameObject.tag == "Player")
        {
            if (fase == 2) 
            {
                StartCoroutine(Fase2());
            }
            else if (fase == 3) 
            {
                Debug.Log("AAAAAAAAA");
                StartCoroutine(Fase3());
            }
              
        }
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        }
    }
    */
    IEnumerator Fase2()
    {
        MetaEventSet.singleton.metaEvents[9].Event.Invoke();
        var a = GameObject.Find("SegundaFase").GetComponent<SegundaFase>();
        a.PrimeiraFaseEvent();
        yield return new WaitForSeconds(2);
        MetaEventSet.singleton.metaEvents[10].Event.Invoke();
        this.gameObject.SetActive(false);
    }
    IEnumerator Fase3()
    {
        MetaEventSet.singleton.metaEvents[11].Event.Invoke();
        var a = GameObject.Find("TerceiraFase").GetComponent<TerceiraFase>();
        a.TerceiraFaseEvent();
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }
}
