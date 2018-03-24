using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ApartmentTextController : MonoBehaviour {

    public Text text;
    private enum States { hallway_0, stairs_0, stairs_1, stairs_2, closet_0, closet_1, hallway_1, hallway_2, hallway_3, hallway_4, hallway_5, roomLeft_0, roomRight_0, roomStraight_0, roomLeft_1, roomRight_1, roomStraight_1, roomEmpty_0, roomEmpty_1, roomStraight_2, roomStraight_3 };
    private States myState;

    void Start()
    {
        myState = States.hallway_0;
    }

    void Update()
    {
        if (myState == States.hallway_0) { hallway_0(); }
        else if (myState == States.stairs_0) { stairs_0(); }
        else if (myState == States.closet_0) { closet_0(); }
        else if (myState == States.closet_1) { closet_1(); }
        else if (myState == States.stairs_1) { stairs_1(); }
        else if (myState == States.stairs_2) { stairs_2(); }
        else if (myState == States.hallway_1) { hallway_1(); }
        else if (myState == States.hallway_2) { hallway_2(); }
        else if (myState == States.hallway_3) { hallway_3(); }
        else if (myState == States.hallway_4) { hallway_4(); }
        else if (myState == States.hallway_5) { hallway_5(); }
        else if (myState == States.roomLeft_0) { roomLeft_0(); }
        else if (myState == States.roomRight_0) { roomRight_0(); }
        else if (myState == States.roomStraight_0) { roomStraight_0(); }
        else if (myState == States.roomLeft_1) { roomLeft_1(); }
        else if (myState == States.roomRight_1) { roomRight_1(); }
        else if (myState == States.roomStraight_1) { roomStraight_1(); }
        else if (myState == States.roomStraight_2) { roomStraight_2(); }
        else if (myState == States.roomStraight_3) { roomStraight_3(); }
        else if (myState == States.roomEmpty_0) { roomEmpty_0(); }
        else if (myState == States.roomEmpty_1) { roomEmpty_1(); }

    }

    void hallway_0()
    {
        text.text = "\tYou move into the entryway of the apartment. There is a staircase on the left and a hallway directly ahead. There is a strong smell of peppermint that soothes and relieves your aches and pains. The floor is a dark, polished hard wood. The walls appear to be painted white with a dark wooden trim adorning the floor and ceilings. There appears to be a closet on the wall to your right.\n\nPress S to go to the Stairs, C to open the closet door, or W to walk down the hall.";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_0; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.closet_0; }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.hallway_1; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void stairs_0()
    {
        text.text = "\tYou decide to chance the stairs despite your bad knees. When you reach the top of the stairs, metal bars and a locked gate prevent you from continuing any further.\n\nPress H to return to the entryway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void closet_0()
    {
        text.text = "\tYou slowly open the closet and discover that this is a coat closet. There appears to be a pair of short cowboy boots in the bottom of the closet, a black backpack, a guitar case, and change of gym clothes. Hanging are three shirts, one with two thumbs on it, one with a series of pictures with a hairy animal in each picture, and one with the picture of an island. There is also a lanyard with a key on it.\n\nPress T to take the lanyard or H to return to the entryway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_0; }
        else if (Input.GetKeyDown(KeyCode.T)) { myState = States.hallway_2; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void hallway_1()
    {
        text.text = "\tYou move down the hallway examining each door as you go. They are all locked. The hallway itself is rather dark, the only light coming from the entryway.\n\nPress R to return to the entryway of the apartment.";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallway_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void hallway_2()
    {
        text.text = "\tYou return to the entryway with key in hand. There is a staircase to your left and the hallway extends before you with rooms on each side and a door at the far end.\n\nPress C to go back to the closet, S to go to up the stairs, or H to walk down the hall.";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_1; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.closet_1; }
        else if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_3; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void stairs_1()
    {
        text.text = "\tYou hobble up the stairs, key in hand. You try the key on the gate but it does not fit.\n\nPress H to return to the Entryway or E to look more closely at the gate.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_2; }
        else if (Input.GetKeyDown(KeyCode.E)) { myState = States.stairs_2; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    
    void stairs_2()
    {
        text.text = "\tAs you examine the gate, you notice that the bars of the gate form a letter in the center of the gate. You cannot tell exactly which letter it is but it appears to be made of a half circle and a straight line.\n\nPress H to return to the Entryway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_2; }
        else if (Input.GetKeyDown(KeyCode.D)) { SceneManager.LoadScene("SecondFloor"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void closet_1()
    {
        text.text = "\tYou look back into the closet. There appears to be a pair of short cowboy boots in the bottom of the closet, a black backpack, a guitar case, and change of gym clothes. Hanging are three shirts, one with two thumbs on it, one with a series of pictures with a hairy animal in each picture, and one with the picture of an island.\n\nPress H to return to the Entryway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_2; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void hallway_3()
    {
        text.text = "\tYou are now in the main hallway. You hear a faint beeping sound coming from the door on the left. There is a door straight ahead at the end of the hall and a door on the right.\n\nPress L to examine the door on the left, R to examine the door on the right, or S to examine the door straight ahead.";
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.roomLeft_0; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.roomRight_0; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.roomStraight_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomLeft_0()
    {
        text.text = "\tYou insert the key into the door and turn it. It unlocks with a loud click. You push the door open slowly. The room is dark and it is difficult to see but you can make out the silhouette of a young man sitting on a chair in the room playing a guitar. He looks up at you and smiles while pointing to the small bed in the room and you notice a shiny object on the bed. It appears to be a key in the shape of an G.\n\nPress T to take the key or H to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_3; }
        else if (Input.GetKeyDown(KeyCode.T)) { myState = States.roomLeft_1; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomRight_0()
    {
        text.text = "\tYou walk to the door and open it with your key but the room is completely empty. You close it behind you and hear it lock spontanesouly.\n\nPress H to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_3; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomStraight_0()
    {
        text.text = "\tYou walk to the door and open it with your key but the room is completely empty. You close it behind you and hear it lock spontanesouly.\n\nPress H to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_3; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomLeft_1()
    {
        text.text = "\tYou take the key in your hand. It appears to be made of solid gold. It is heavy and is engraved with an G. When you look up and notice the man is gone and the room is empty.\n\nPress H to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_4; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomRight_1()
    {
        text.text = "\tYou unlock the door on the right and enter slowly. Another young man is sitting at a desk with red headphones next to him. He appears to be reading something. He glances at you and appears to be saying something but you cannot hear him. He stands up and walks over to you. Despite the fact he is standing in front of you, you can barely see him. He takes your hand and places something in it. Then he pushes you out of the room and closes the door. You look down at your hand and realize it is another key, this time made of a polished titanium and with the letter S engraved on it.\n\nPress H to go back to the hallway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_5; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomStraight_1()
    {
        text.text = "\tThe third door now has a small window built into it. Looking through it, you see four people sitting around a long table in the dark. There is a candle on the table in front of them. They seem to be eating something and talking. You watch for a minute taking note of the fact that they all seem to be very close, almost like family. You catch a whiff of melting chocolate and marshmallow. You can’t explain why but you just want to get into that room and join these people.\n\nPress Space open the door...";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.roomStraight_2; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void hallway_4 ()
    {
        text.text = "\tYou return to the hallway. The door on your right and the door directly ahead both remain. A faint beeping sound comes from the door on the right.\n\nPress R to open the door on the right, L to go to the door on the left, or S to go to the door ahead.";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.roomRight_1; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.roomEmpty_0; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.roomEmpty_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void hallway_5()
    {
        text.text = "\tYou return to the hallway. There is a room at the end of the hall, one to the left and one to the right.\n\nPress S to go to the room at the end of the hall, R to go to the room on the right, L to go to the room on the left.";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.roomStraight_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.roomEmpty_1; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.roomEmpty_1; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomStraight_2 ()
    {
        text.text = "\tYou turn the door knob and push the door open quickly but when you step inside the room is empty except for a young lady. It is too dark to see much but you can tell she has long, light colored hair. She smiles but her smile does not appear to be genuine. She seems to be hiding some sadness behind it. She pulls something out of her pocket and tosses it to you. You catch it in your hand and look down at the object: the letter H made of beautiful green polished stone in the shape of a key. You think it might be made of jade.\n\nPress Space open to continue...";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.roomStraight_3; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    
    void roomStraight_3 ()
    {
        text.text = "\tYou look up from your hands and she is gone. All that remains is the room. You look to your left and there are shelves full of books and various supplies. There appear to be books written in French on the shelf. To the right a whiteboard and poster are attached to the wall. You stand for a long moment, taking it all in.\n\nPress Space to turn and leave the room.";
        if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Market"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomEmpty_0 ()
    {
        text.text = "\tThe room is empty. You've done all you can here.\n\nPress H to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_4; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void roomEmpty_1()
    {
        text.text = "\tThe room is empty. You've done all you can here.\n\nPress H to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway_5; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }
}
