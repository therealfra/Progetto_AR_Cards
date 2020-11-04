using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterCardBehaviour : MonoBehaviour
{
    public GameObject Barchetta;

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
        if (other.gameObject.name == "Barchettacard")
        {
            Barchetta.SetActive(true);

            print("Barchetta attiva");
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "Barchettacard")
        {
            Barchetta.SetActive(false);
             print("Barchetta disattiva");
        }   


    }
}


