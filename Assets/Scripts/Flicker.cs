using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    AudioSource audioSource;
    AudioClip audioClip;

    void Start() {
        x = 0;
        parentObj = transform.parent.gameObject;
        rendererObj = parentObj.GetComponent<Renderer>();
        rendererObj.enabled = true;
        rendererObj.sharedMaterial = material[x];

        lightObj = GetComponent<Light>();
        timer = Random.Range(minTime, maxTime);

        audioSource = parentObj.GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("SFX/FlickerSFX");
        audioSource.clip = audioClip;
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
            
            Debug.Log("Flicker");
            audioSource.Play();
        }
    }
}
