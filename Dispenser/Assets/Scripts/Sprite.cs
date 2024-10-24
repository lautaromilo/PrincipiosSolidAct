using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject sprite, Transform posicion)
    {
        Debug.Log("Liberar Sprite");

        if (sprite != null && posicion != null)
        {
            if (!gameObject.activeInHierarchy)
            {
                Reactivar(posicion);

            }

            else
            {
                GameObject instancia = Instantiate(sprite, posicion.position, posicion.rotation);
                instancia.transform.position = new Vector3(posicion.position.x, posicion.position.y - 0.5f, posicion.position.z);
            }
        }



    }



   
}
