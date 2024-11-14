using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Dispenser : MonoBehaviour
{
    public GameObject coca;
    public GameObject agua;
    public GameObject sprite;
    public GameObject fanta;

    private GameObject soloagua;
    private GameObject gaseosas;

    private IFactory factory;

    void Start()
    {
        soloagua = GameObject.Find("SoloAgua");
        gaseosas = GameObject.Find("Gaseosas");

        factory = GetComponent<CreadorLiquidos>();

    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.D))
        {
            ILiquidos newcoca = factory.CrearLiquido("Coca");
            
            if (newcoca != null)
            {
                Debug.Log("Entro a liberar Coca");
                newcoca.Liberar(coca, gaseosas.transform);
            }

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ILiquidos newagua = factory.CrearLiquido("Agua");
            
            if (newagua != null)
            {
                Debug.Log("Entro a liberar Agua");

                newagua.Liberar(agua, soloagua.transform);

            }

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ILiquidos newsprite = factory.CrearLiquido("Sprite");          

            if (newsprite != null)
            {
                Debug.Log("Entro a liberar Sprite");
                newsprite.Liberar(sprite, gaseosas.transform);

            }

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            ILiquidos newfanta = factory.CrearLiquido("Fanta");
            
            if (newfanta != null)
            {
                Debug.Log("Entro a liberar fanta");

                newfanta.Liberar(fanta, gaseosas.transform);
            }

        }



    }
}
