using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour
{
    private List<Light> lights = new List<Light>();
    private Collider collider;

    private void Awake()
    {
        collider = GetComponent<Collider>();
        lights.AddRange(FindObjectsOfType<Light>());
    }

    private void TurnOffLights()
    {
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TurnOffLights();
            Destroy(collider);
        }
    }
}
