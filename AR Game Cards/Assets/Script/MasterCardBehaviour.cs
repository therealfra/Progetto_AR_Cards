using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterCardBehaviour : MonoBehaviour
{
    public GameObject Pini;
    public GameObject Tenda;
    public GameObject Erba;
    public GameObject Panchina;
    public GameObject Tartaruga;
    public GameObject Uccello;
    public GameObject AlberiInFiore;
    public GameObject AlberiVerdi;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PiniCard")
        {
            Pini.SetActive(true);

        }

        if (other.gameObject.name == "ErbaCard")
        {
            Erba.SetActive(true);

        }

         if (other.gameObject.name == "TendaCard")
        {
            Tenda.SetActive(true);

        }

          if (other.gameObject.name == "PanchinaCard")
        {
            Panchina.SetActive(true);

        }

          if (other.gameObject.name == "TartarugaCard")
        {
            Tartaruga.SetActive(true);

        }

          if (other.gameObject.name == "UccelloCard")
        {
            Uccello.SetActive(true);

        }

          if (other.gameObject.name == "AIFCard")
        {
           AlberiInFiore.SetActive(true);

        }

           if (other.gameObject.name == "AVCard")
        {
           AlberiVerdi.SetActive(true);

        }


    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "PiniCard")
        {
            Pini.SetActive(false);

        }
        
        if (other.gameObject.name == "TendaCard")
        {
            Tenda.SetActive(false);

        }

        if (other.gameObject.name == "ErbaCard")
        {
            Erba.SetActive(false);

        }

         if (other.gameObject.name == "PanchinaCard")
        {
            Panchina.SetActive(false);

        }

        
          if (other.gameObject.name == "TartarugaCard")
        {
            Tartaruga.SetActive(false);

        }

        
          if (other.gameObject.name == "UccelloCard")
        {
            Uccello.SetActive(false);

        }

             if (other.gameObject.name == "AIFCard")
        {
           AlberiInFiore.SetActive(false);

        }

          if (other.gameObject.name == "AVCard")
        {
           AlberiVerdi.SetActive(false);

        }
    }
}


