using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondFloorTextController : MonoBehaviour {

    public Text text;
    public AudioSource dryer;
    private enum States { gate_0, hallway_0, laundry_0, restroom_0, rooms_0, window_0, hallway_1, laundry_1, restroom_1, room4_1, room5_1, room6_1, window_1, };
    private States myState;

    void Start()
    {
        myState = States.gate_0;
        dryer = GameObject.FindGameObjectWithTag("Sounds").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (myState == States.gate_0) { gate_0(); }
        else if (myState == States.hallway_0) { hallway_0(); }
        else if (myState == States.hallway_1) { hallway_1(); }
        else if (myState == States.laundry_0) { laundry_0(); }
        else if (myState == States.laundry_1) { laundry_1(); }
        else if (myState == States.restroom_0) { restroom_0(); }
        else if (myState == States.restroom_1) { restroom_1(); }
        else if (myState == States.rooms_0) { rooms_0(); }
        else if (myState == States.room4_1) { room4_1(); }
        else if (myState == States.room5_1) { room5_1(); }
        else if (myState == States.room6_1) { room6_1(); }
        else if (myState == States.window_0) { window_0(); }
        else if (myState == States.window_1) { window_1(); }
    }
    void gate_0 ()
    {
        text.text = "\tYou place your hand on the line of the D and pull. The gate makes a loud clicking sound and opens slowly. You step forward through the gate and examine the hallway before you. It looks like the one below. You hear a metal clicking sound and turn around in time to see the gate close and lock behind you. You are trapped.\n\nPress W to walk down the hallway. PRESS SPACE TO TELEPORT BACK IN TIME.";
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.hallway_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
    }

    void hallway_0 ()
    {
        text.text = "\tThe hallway stretches before you, dead ending in a window that looks out on a back alley. Five doors line the the hall, three on the right and one on the left. You examine the doors to discover that they are numbered 4, 5, 6, Restroom, and Laundry Mat. A melodious tune wafts down the hallway.\n\nPress R to go to the restroom, L to go to the laundry mat, W to look out the window, or E to examine the three other rooms.\n\n";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.restroom_0; }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.laundry_0;
            dryer.Play();
        }
        else if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
    }

    void laundry_0 ()
    {
        text.text = "\tYou walk up to the room marked with a sign that reads: \"Laundry Mat: Residents Only.\" The door is propped open. One of the washing machines is running. There is a note left on it.\n\nPress L to go read the note, R to go to the restroom, W to go to the Window, or E to examine the three other rooms.\n\n";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.restroom_0; dryer.Stop(); }
        else if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; dryer.Stop(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; dryer.Stop(); }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_1; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

    void restroom_0 ()
    {
        text.text = "\tYou walk to the restroom door and realize it is open. You look inside but can't see anything because the lights are off.\n\nPress T to turn on the lights, L to go to the laundry mat, W to go to the Window, or E to examine the three other rooms.\n\n";
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

    void rooms_0 ()
    {
        text.text = "\tYou approach the three doors on the right. They are all closed. The last one has a long rectangular window built into it.\n\nPress F to go to room four, V to go to room five, or S to go to room Six.\n\n";
        if (Input.GetKeyDown(KeyCode.F)) { myState = States.room4_1; }
        else if (Input.GetKeyDown(KeyCode.V)) { myState = States.room5_1; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.room6_1; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

    void window_0 ()
    {
        text.text = "\tThe window is partially open and a gentle breeze blows over you as you approach the window. You reach the window and gaze outside it. Behind the apartment building is a narrow, cobblestone road that twists and bends into the distance. It seems old, almost european.\n\nPress P to try and open the window all the way, the R to go to the restroom, L to go to the laundry mat, or E to examine the three other rooms.\n\n";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.restroom_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

    void hallway_1()
    {
        text.text = "\t\n\n";
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

    void laundry_1()
    {
        text.text = "\tYou hobble into the laundry room looking around as you walk towards the note There are four machines on the left, four on the right, and eight in the middle. The air is dry and smells of fresh linen. As you approach the note, you notice that it appears to be a list of chores. Laundry is on the list and has not been checked off yet.\n\nPress L to go read the note, R to go to the restroom, W to go to the Window, or E to examine the three other rooms.\n\n";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.restroom_0; dryer.Stop(); }
        else if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; dryer.Stop(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; dryer.Stop(); }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }

    }
    void restroom_1()
    {
        text.text = "\tYou step in and flip the light switch. Three out of four bulbs illuminate the scene. The bathroom smells of fresh lemon. On the sink is a soap despenser in the shape of Darth Vaders head. You don't need to use the restroom and there isn't much else of interest here.\n\nPress L to go to the laundry mat, W to go to the Window, or E to examine the three other rooms.\n\n";
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }
    void room4_1()
    {
        text.text = "\t\n\n";
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

    void room5_1()
    {
        text.text = "\t\n\n";
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

    void room6_1()
    {
        text.text = "\t\n\n";
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.window_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }
    void window_1()
    {
        text.text = "\tWith all your strenght you try to push the window up and open it the rest of the way. However, there is a long metal bar that is locked in place that prevents you from moving the window any further. Glancing outside, you notice there is a dumpster below you.\n\nPress R to go to the restroom, L to go to the laundry mat, or E to examine the three other rooms.\n\n";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.restroom_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.laundry_0; dryer.Play(); }
        else if (Input.GetKeyDown(KeyCode.E)) { myState = States.rooms_0; }
        else if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }
}
