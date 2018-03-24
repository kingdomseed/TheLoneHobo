using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    private AudioSource audioSource;
    private float audioTimer = 0.0f;
	public void LoadLevel(string name)
    {
        StartCoroutine(LoadLevelTimer(audioTimer, name));
        
    }
	public void Next(string name)
    {
        StartCoroutine(LoadLevelTimer(audioTimer, name));
        
    }
	
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioTimer = audioSource.clip.length;
        
    }

    void Update()
	{
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
		else if(Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
	}	

    IEnumerator LoadLevelTimer(float audioTimer, string name)
    {
        yield return new WaitForSeconds(audioTimer);
        SceneManager.LoadScene(name);
    }

}
