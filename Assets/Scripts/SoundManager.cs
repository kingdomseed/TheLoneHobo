using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    public GameObject BGSoundsPlayer;

    void Awake()
    {

        //When the scene loads it checks if there is an object called "MUSIC".
        BGSoundsPlayer = GameObject.Find("BGSOUND");
        if (BGSoundsPlayer == null)
        {
            //If this object does not exist then it does the following:
            //1. Sets the object this script is attached to as the music player
            BGSoundsPlayer = this.gameObject;
            //2. Renames THIS object to "MUSIC" for next time
            BGSoundsPlayer.name = "BGSOUND";
            //3. Tells THIS object not to die when changing scenes.

            DontDestroyOnLoad(BGSoundsPlayer);

        }
        else
        {
            if (this.gameObject.name != "BGSOUND")
            {
                //If there WAS an object in the scene called "MUSIC" (because we have come back to
                //the scene where the music was started) then it just tells this object to 
                //destroy itself if this is not the original
                Destroy(this.gameObject);
            }
        }

    }
}
