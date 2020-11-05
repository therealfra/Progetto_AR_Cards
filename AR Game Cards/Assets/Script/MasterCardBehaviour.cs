using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterCardBehaviour : MonoBehaviour
{
    public GameObject Pini;

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
        if (other.gameObject.name == "Carta_Pini")
        {
            Pini.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "Carta_Pini")
        {
            Pini.SetActive(false);

        }


    }
}


