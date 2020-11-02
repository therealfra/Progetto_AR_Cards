using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       MeshRenderer meshComponent = GetComponent<MeshRenderer>();
        if (meshComponent != null)
             {
            Debug.Log("Trovato!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
