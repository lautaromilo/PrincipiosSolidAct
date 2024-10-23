using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClaseLiquido : MonoBehaviour , ILiquidos
{


    public abstract void Liberar(GameObject agua, Transform posicion);
    
    public abstract void Desaparecer();



}
