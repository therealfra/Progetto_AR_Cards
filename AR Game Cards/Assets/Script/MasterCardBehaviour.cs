using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterCardBehaviour : MonoBehaviour
{
    public GameObject Pini;
    public GameObject Tenda;
    public GameObject Erba;

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

    }
}


