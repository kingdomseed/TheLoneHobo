using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TheRoomTextController : MonoBehaviour {

    public Text text;
    private enum States { room_0, room_1 };
    private States myState;

    void Start()
    {
        myState = States.room_0;
    }

    void Update()
    {
        if (myState == States.room_0) { room_0(); }
        else if (myState == States.room_1) { room_1(); }

    }

    void room_0()
    {
        text.text = "\tYou blink your eyes over and over again. The light burns your eyes. Its as if you are opening them for the first time. You are breathing heavily. There is a mask on your face.  You are lying on your back in a bed. Your whole body aches and you can barely move.\n\nPress Space to continue.";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.room_1; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void room_1()
    {
        text.text = "\tAs your eyes begin to adjust to the light, you notice a machine next to you beeping steadily. There are tubes going into your arms. The door to your room is open and people are standing in the hallway speaking softly. On a couch nearby, three kids are fast asleep. Memroies begin to flood back into your mind. Tears fill your eyes as you realize who you are. You are not alone. You are not a hobo.\n\nPress Space to go to the Credits.";
        if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Credits"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }
}
