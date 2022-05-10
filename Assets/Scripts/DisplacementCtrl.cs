using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplacementCtrl : MonoBehaviour
{
    public float displacementAmount;
    public float DisAlpha;

    public ParticleSystem explosionParticles;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        displacementAmount = Mathf.Lerp(displacementAmount, 0, Time.deltaTime);
        DisAlpha = Mathf.Lerp(DisAlpha,0, Time.deltaTime);

        meshRenderer.material.SetFloat("_Amount", displacementAmount);        meshRenderer.material.SetFloat("_Alpha", DisAlpha);

        if (Input.GetButtonDown("Fire1"))        {            displacementAmount += 1f;            DisAlpha += 1f;            explosionParticles.Play();        }
    }
}
