using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeDoor
{
    chaveadas,
    nChaveada,
}
public class ClassePorta
{
    public GameObject portaPrebab;
    public TypeDoor tipo;
    public bool aberta;
    public string id;

    public ClassePorta(TypeDoor tipo, bool aberta, string id)
    {
        this.id = id;
        this.tipo = tipo;
        this.aberta = aberta;
    }

    public void Ativar()
    {
        portaPrebab.SetActive(true);
    }
    public void Desativar()
    {
        portaPrebab.SetActive(false);
    }
}
