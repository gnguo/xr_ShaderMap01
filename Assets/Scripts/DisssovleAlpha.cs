using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisssovleAlpha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Renderer Bat = gameObject.GetComponent<Renderer>();

        Bat.material.SetFloat("_AlphaControl", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
