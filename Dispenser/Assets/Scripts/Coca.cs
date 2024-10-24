using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coca : ClaseLiquido, ILiquidos
{
    public override void Liberar(GameObject coca, Transform posicion)
    {
        Debug.Log("Liberar Coca");
        
        if (coca != null && posicion != null)
        {
            if (!gameObject.activeInHierarchy)
            {
                Reactivar(posicion);

            }

            else
            {
                GameObject instancia = Instantiate(coca, posicion.position, posicion.rotation);
                instancia.transform.position = new Vector3(posicion.position.x, posicion.position.y - 0.5f, posicion.position.z);
            }
        }
    }


 


}
