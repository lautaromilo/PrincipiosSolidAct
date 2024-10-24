using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject agua, Transform posicion)
    {
        Debug.Log("Liberar Agua");
        
        if (agua != null && posicion != null)
        {
            if (!gameObject.activeInHierarchy)
            {
                Reactivar(posicion);

            }

            else
            {
                GameObject instancia = Instantiate(agua, posicion.position, posicion.rotation);
                instancia.transform.position = new Vector3(posicion.position.x, posicion.position.y - 0.5f, posicion.position.z);
            }
        }
    }

    
}
