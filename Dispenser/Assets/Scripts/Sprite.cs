using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject sprite, Transform posicion)
    {
        Debug.Log("Liberar Sprite");

        GameObject instancia = Instantiate(sprite, posicion.position, posicion.rotation);

    }

    public override void Desaparecer()
    {
        //Destroy(this);

        Debug.Log("Chau Sprite");
    }
    

   
}
