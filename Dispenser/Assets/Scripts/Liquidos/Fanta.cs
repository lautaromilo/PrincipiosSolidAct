using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanta : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject fanta, Transform posicion)
    {
        Debug.Log("Liberar Fanta");

        if (fanta != null && posicion != null)
        {
            if (!gameObject.activeInHierarchy)
            {
                Reactivar(posicion);
            }

            else
            {
                GameObject instancia = Instantiate(fanta, posicion.position, posicion.rotation);
                instancia.transform.position = new Vector3(posicion.position.x, posicion.position.y - 0.5f, posicion.position.z);
            }
        }

    }

}
