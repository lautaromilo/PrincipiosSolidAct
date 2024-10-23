using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject agua, Transform posicion)
    {
        Debug.Log("Liberar Agua");
    }

    public override void Desaparecer()
    {
        Debug.Log("Chau Agua");
    }

    
}
