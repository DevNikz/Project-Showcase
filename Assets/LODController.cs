using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LODController : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);

            // if(gameObject.name == "StorageLOD") {
            //     Debug.Log("Remove Main!");
            //     // SceneManager.UnloadSceneAsync(2,UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
            //     // SceneManager.UnloadSceneAsync(4,UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
                
            // }
        }   
    }

    void OnTriggerExit(Collider other) {
        SceneManager.UnloadSceneAsync(3,UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        // if(gameObject.name == "StorageLOD") {
        //     Debug.Log("Adding Main!");
        //     // SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
        //     // SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
        // }
    }
}
