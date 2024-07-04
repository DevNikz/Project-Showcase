using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private GameObject light1;
    private GameObject light2;
    private bool enableLight;

    void Awake() {
        light1 = transform.Find("Light1").gameObject;
        light2 = transform.Find("Light2").gameObject;
        enableLight = true;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) ToggleLight();
        UpdateLight();
    }

    void UpdateLight() {
        switch(enableLight) {
            case true:
                light1.SetActive(true);
                light2.SetActive(true);
                break;
            case false:
                light1.SetActive(false);
                light2.SetActive(false);
                break;
        }
    }

    void ToggleLight() {
        if(enableLight) enableLight = false;
        else enableLight = true;
    }
}
