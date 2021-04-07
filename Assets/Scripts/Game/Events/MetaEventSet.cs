using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MetaEvent
{
    public string Name;
    public int ID;
    public UnityEvent Event;
}

[System.Serializable]
public class MetaEventSet : MonoBehaviour
{
    public List<MetaEvent> metaEvents;
    public static MetaEventSet singleton;
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