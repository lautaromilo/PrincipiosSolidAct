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


    void Start()
    {
        soloagua = GameObject.Find("SoloAgua");
        gaseosas = GameObject.Find("Gaseosas");

    }



    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.D))
        {
            Coca newcoca = coca.GetComponent<Coca>();

            if (newcoca != null)
            {
                Debug.Log("Entro a liberar Coca");
                newcoca.Liberar(coca, gaseosas.transform);
            }

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Agua newagua = agua.GetComponent<Agua>();

            if (newagua != null)
            {
                Debug.Log("Entro a liberar Agua");

                newagua.Liberar(agua, soloagua.transform);

            }

        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            Sprite newsprite = sprite.GetComponent<Sprite>();
          

            if (newsprite != null)
            {
                Debug.Log("Entro a liberar Sprite");
                newsprite.Liberar(sprite, gaseosas.transform);

            }

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Fanta newfanta = fanta.GetComponent<Fanta>();

            if (newfanta != null)
            {
                Debug.Log("Entro a liberar fanta");

                newfanta.Liberar(fanta, gaseosas.transform);
            }

        }



    }
}
