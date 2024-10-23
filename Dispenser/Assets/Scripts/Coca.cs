using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coca : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject coca, Transform posicion)
    {
        Debug.Log("Liberar Coca");
    }

    public override void Desaparecer()
    {
        Debug.Log("Chau Coca");
    }

 


}
