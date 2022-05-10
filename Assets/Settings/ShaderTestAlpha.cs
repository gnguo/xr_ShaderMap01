using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderTestAlpha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Renderer sphereREnderer = gameObject.GetComponent<Renderer>();

        sphereREnderer.material.SetFloat("AlphaControl", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
