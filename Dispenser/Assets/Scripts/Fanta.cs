using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanta : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject fanta, Transform posicion)
    {
        Debug.Log("Liberar Fanta");
    }

    public override void Desaparecer()
    {
        Debug.Log("Chau Fanta");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
