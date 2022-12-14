using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour
{

    Material myMaterial;
    private float minEmission = 0.2f, magEmission = 2.0f;
    private int degreee = 0, speed = 5;
    Color defaultColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        if (tag == "SmallStarTag")
        {
            this.defaultColor = Color.white;
        }
        else if (tag == "LargeStarTag")
        {
            this.defaultColor = Color.red;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaultColor = Color.cyan;
        }

        this.myMaterial = GetComponent<Renderer>().material;

        myMaterial.SetColor("_EmissionColor", this.defaultColor*minEmission);
    }


    // Update is called once per frame
    void Update()
    {
        if (this.degreee >= 0)
        {
            Color emissionColor = this.defaultColor * (this.minEmission
                + Mathf.Sin(this.degreee * Mathf.Deg2Rad) * this.magEmission);

            myMaterial.SetColor("_EmissionColor", emissionColor);

            this.degreee -= this.speed;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        this.degreee = 180;
    }
}
