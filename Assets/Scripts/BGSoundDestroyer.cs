using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BGSoundDestroyer : MonoBehaviour {

    private string scene;
    public GameObject BGSoundsPlayer;
    // Use this for initialization
    void Start()
    {
        BGSoundsPlayer = GameObject.FindGameObjectWithTag("DestroyOnEntry");
        scene = SceneManager.GetActiveScene().name;
        if (scene == "Apartment")
        {
            DestroyObject(BGSoundsPlayer);
        }
    }
}
