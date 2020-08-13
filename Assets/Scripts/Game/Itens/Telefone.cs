using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Telefone : Item
{
    public void Vericacao()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            this.gameObject.SetActive(false);
        }
    }
    public List<SetEvents> Events;
    public Text texto;
    public GameObject p1;
    public override void EventTriggerRay()
    {
      //  Vericacao();
        if (Input.GetKeyDown("e"))
        {
            var a = GameObject.Find("StopSystem").GetComponent<Inventario>();
            if (a.Events[0].ID == 4)
            {
                a.Events[0].Event.Invoke();
            }

            if (Events[0].ID == 5)
            {
                p1.SetActive(true);
                Events[0].Event.Invoke();
                StartCoroutine(Conversa());
            }
        }
    }

    IEnumerator Conversa()
    {
        texto.text = "Veja só quem acordou...";
        yield return new WaitForSeconds(6);
        texto.text = "Todos estão ansiosos pela nossa chegada.";
        yield return new WaitForSeconds(6);
        texto.text = "Nossos encontros serão breves, vou te ajudar um pouco.";
        yield return new WaitForSeconds(6);
        texto.text = "Seu estado mental é importante, cuide de nós!";
        yield return new WaitForSeconds(6);
        texto.text = "De uma olhada em baixo do vaso, no corredor.";
        yield return new WaitForSeconds(3);
        texto.text = "";
        p1.SetActive(false);
        var a = GameObject.Find("StopSystem").GetComponent<Inventario>();
        if (a.Events[1].ID == 4)
        {
            a.Events[1].Event.Invoke();
        }
    }
}
