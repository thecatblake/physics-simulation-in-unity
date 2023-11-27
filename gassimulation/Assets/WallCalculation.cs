using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WallCalculation : MonoBehaviour
{
    public TextMeshProUGUI pressureText;
    
    public float pressure = 0;

    private long hitNum = 0;

    public float area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        var particleComponent = other.gameObject.GetComponent<RandomInitialVelocity>();
        if (particleComponent == null) return;
        
        hitNum++;
        var f = particleComponent.rb.mass * particleComponent.rb.velocity.magnitude * 2 / Time.deltaTime;
        pressure += (f - pressure) / hitNum;

        pressureText.text = pressure.ToString(CultureInfo.CurrentCulture);
    }
}
