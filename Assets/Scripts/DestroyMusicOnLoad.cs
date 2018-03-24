using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyMusicOnLoad : MonoBehaviour {

    private string scene;
    public GameObject musicPlayer;
	// Use this for initialization
	void Start ()
    {
        musicPlayer = GameObject.FindGameObjectWithTag("DestroyOnFinal");
        scene = SceneManager.GetActiveScene().name;
        if (scene == "Final")
        {
            DestroyObject(musicPlayer);
        }
    }

}
