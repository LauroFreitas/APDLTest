using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColideEventCorredor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Fase2());
           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        }
    }
    IEnumerator Fase2()
    {
        MetaEventSet.singleton.metaEvents[9].Event.Invoke();
        var a = GameObject.Find("SegundaFase").GetComponent<SegundaFase>();
        a.PrimeiraFaseEvent();
        yield return new WaitForSeconds(2);
        MetaEventSet.singleton.metaEvents[10].Event.Invoke();
        this.gameObject.SetActive(false);
    }
}
