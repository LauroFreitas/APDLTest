using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTelefone : MonoBehaviour
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
        yield return new WaitForSeconds(33);
        this.gameObject.SetActive(false);
    }
}
