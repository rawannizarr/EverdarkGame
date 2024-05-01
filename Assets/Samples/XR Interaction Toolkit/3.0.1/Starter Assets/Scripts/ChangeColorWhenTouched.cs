using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWhenTouched : MonoBehaviour
{
    private Renderer objectRenderer;
    private Material defaultMaterial;
    public Material newMaterial;
    public string tag;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        defaultMaterial = objectRenderer.material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            objectRenderer.material = newMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            objectRenderer.material = defaultMaterial;
        }
    }
}
