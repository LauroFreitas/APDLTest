using System.Collections;
using System.Collections.Generic;
using UnityEngine;

delegate void AnimDelegate(int ID);
public class Animacoes : MonoBehaviour
{
    public Animator Animator;
    static public Animacoes singleton;
    AnimDelegate animDelegate;
    public bool desativar = true;
    virtual public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        }
    }
    virtual public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
        }
    }
}
 