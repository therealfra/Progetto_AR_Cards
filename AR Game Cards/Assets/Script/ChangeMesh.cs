using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMesh : MonoBehaviour
{
    // Start is called before the first frame update
       
    public Mesh Mesh;
    private Mesh MeshToSwap;

    private MeshFilter Target;

    public float Timer = 3f;

    private float ElapsedTime = 0f;
    void Start()
    {
        Target = GetComponent<MeshFilter>();
        MeshToSwap = Mesh;
    }

    // Update is called once per frame
    void Update()
    {
        if (Target == null) return;

        ElapsedTime += Time.deltaTime;
        if (ElapsedTime >= Timer)
        {
            ElapsedTime = 0;
            Mesh OldMesh = Target.mesh;
            Target.mesh = MeshToSwap;
            MeshToSwap = OldMesh;
        }
    }
}

    
