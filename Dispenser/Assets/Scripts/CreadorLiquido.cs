using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreadorLiquidos : MonoBehaviour , IFactory
{
    public GameObject cocaPrefab;
    public GameObject fantaPrefab;
    public GameObject aguaPrefab;
    public GameObject spritePrefab;

    public ILiquidos CrearLiquido(string liquido)
    {
        GameObject liquidoObj = null;

        switch (liquido)
        {
            case "Coca":
                liquidoObj = GameObject.Instantiate(cocaPrefab);
                break;
            case "Fanta":
                liquidoObj = GameObject.Instantiate(fantaPrefab);
                break;
            case "Agua":
                liquidoObj = GameObject.Instantiate(aguaPrefab);
                break;
            case "Sprite":
                liquidoObj = GameObject.Instantiate(spritePrefab);
                break;
            default:
                throw new ArgumentException("Tipo de líquido desconocido");
        }

        return liquidoObj.GetComponent<ILiquidos>();
    }
}