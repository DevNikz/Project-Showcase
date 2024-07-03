using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public GameObject parentObj;
    public Light lightObj;
    public float minTime;
    public float maxTime;
    public float timer;
    public Material[] material;
    public int x;
    Renderer rendererObj;

    void Start() {
        x = 0;
        parentObj = transform.parent.gameObject;
        rendererObj = parentObj.GetComponent<Renderer>();
        rendererObj.enabled = true;
        rendererObj.sharedMaterial = material[x];

        lightObj = GetComponent<Light>();
        timer = Random.Range(minTime, maxTime);
    }

    void Update() {
        rendererObj.sharedMaterial = material[x];
        Flickering();
    }

    void Flickering() {
        if(timer > 0) {
            timer -= Time.fixedDeltaTime;
        }
        if(timer <= 0) {
            if(x < 1) {
                x++;
            }
            else {
                x=0;
            }

            lightObj.enabled = !lightObj.enabled;
            timer = Random.Range(minTime,maxTime);
        }
    }
}
