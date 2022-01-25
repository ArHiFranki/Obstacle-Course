using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(MeshRenderer))]
public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 5f;

    private Rigidbody myRigidbody;
    private MeshRenderer myMeshRenderer;
    private bool isObjectAlreadyDrop;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        myRigidbody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    private void Update()
    {
        DropObject();
    }

    private void DropObject()
    {
        if (Time.time >= timeToWait && !isObjectAlreadyDrop)
        {
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
            isObjectAlreadyDrop = true;
        }
    }
}
