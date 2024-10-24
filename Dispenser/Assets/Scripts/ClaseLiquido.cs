using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClaseLiquido : MonoBehaviour , ILiquidos
{
    public float velocidadCaida = 2f;

    public abstract void Liberar(GameObject agua, Transform posicion);
    
    public void MovimientoCaida()
    {
        transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime);

        if (transform.position.y < -2f)
        {
            Desaparecer();
        }
    }
    
    public virtual void Update()
    {
        MovimientoCaida();
    }
    

    public void Desaparecer()
    {
        gameObject.SetActive(false);  
    }

    public void Reactivar (Transform posicion)
    {
        gameObject.SetActive(true); 
        transform.position = posicion.position;
    }



}
