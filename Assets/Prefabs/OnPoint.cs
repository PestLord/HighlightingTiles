using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnPoint : MonoBehaviour
{
    [SerializeField] private Material chosenMaterial;

    private Material initialMaterial;
    // Start is called before the first frame update
    void Start()
    {
        initialMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = chosenMaterial;
        
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = initialMaterial;
       
    }
}
