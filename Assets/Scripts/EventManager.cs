using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

 
[System.Serializable]
public class EventManager : MonoBehaviour
{
    public List<SetEvents> Events;
    public static EventManager singleton;
    private void Awake()
    {
        NoDestroy();

    }
    void NoDestroy()//criando singleton
    {
        //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena
        DontDestroyOnLoad(gameObject);

        if (singleton == null && singleton != this)
        {
            singleton = this;

            //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}