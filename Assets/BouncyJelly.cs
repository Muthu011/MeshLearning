using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyJelly : MonoBehaviour
{
    public static BouncyJelly bouncy;

    public GameObject[] Bones;
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public Mesh cubeMesh;

    public Vector3 centre;
    public Vector3 temp;

    public void Awake()
    {
        bouncy = this;
    }

    public void Update()
    {
        for (int i = 0; i < Bones.Length; i++)
        {
            centre += Bones[i].transform.position;
        }

        centre = centre / Bones.Length;
        transform.position = centre;
        centre = Vector3.zero;
        playerMeshCollider();

    }

    void playerMeshCollider()
    {
        skinnedMeshRenderer.BakeMesh(cubeMesh);
        gameObject.GetComponent<MeshCollider>().sharedMesh = cubeMesh;

    }

}
