using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private GameObject parent;
    private bool playerDetected;

    void Start() {
        parent = transform.parent.gameObject;
        playerDetected = false;
    }

    void Update() {
        if(playerDetected) {
            Debug.Log("Detected!");
            if(parent.transform.position.y < 6f) {
                parent.transform.Translate(0f, 2.5f * Time.fixedDeltaTime, 0f);
            }
        }
        else {
            if(parent.transform.position.y > 2.5f) {
                parent.transform.Translate(0f, -2.5f * Time.fixedDeltaTime, 0f);
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            playerDetected = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")) {
            playerDetected = false;
        }
    }
}
