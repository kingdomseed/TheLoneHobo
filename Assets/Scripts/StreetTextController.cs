using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StreetTextController : MonoBehaviour {

    public Text text;
    private enum States { street_0, apartment_0, market_0, marketDoor_0, apartmentDoor_0, letter_0, letter_1, apartmentDoor_1, break_0 };
    private States myState;

    void Start()
    {
        myState = States.street_0;
    }

    void Update()
    {
        if (myState == States.street_0) { street_0(); }
        else if (myState == States.market_0) { market_0(); }
        else if (myState == States.marketDoor_0) { marketDoor_0(); }
        else if (myState == States.apartment_0) { apartment_0(); }
        else if (myState == States.apartmentDoor_0) { apartmentDoor_0(); }
        else if (myState == States.apartmentDoor_1) { apartmentDoor_1(); }
        else if (myState == States.letter_0) { letter_0(); }
        else if (myState == States.letter_1) { letter_1(); }
        else if (myState == States.break_0) { break_0(); }
    }

    void street_0 ()
    {
        text.text = "\tYou hobble after the letter as it blows down the street. Old, three story apartments line the left and right side of the street. Some of these apartments have doormats. Others have small potted plants sitting near the entry way. There are several trees moving gently in the wind. The wind dies down and the letter comes to rest on the door mat of an apartment nearby. You see a small market in the distance.\n\nPress A to walk to the apartment or M to walk to the market.";
        if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.apartment_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void market_0 ()
    {
        text.text = "\tYou glance briefly back at the letter and notice it seems to be stuck partially under a door mat. You turn and walk towards the market. The market exterior is painted a dark green. Intricate designs are woven below the windows and the door itself is quite ornate, made of wood painted green and glass. There's a dim light coming from the back of the market. The words\"The Promised Land\" appear arched over the entryway in gold.\n\nPress D to check the door or A to return to the apartment.";
        if (Input.GetKeyDown(KeyCode.D)) { myState = States.marketDoor_0; }
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.apartment_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void apartment_0 ()
    {
        text.text = "\tYou hobble slowly towards the apartment. The letter is stuck partially under a door mat. As you reach the apartment door and the door mat, you pause briefly and lean against the handrail. There doesn't seem to be anything special about the entrance to the apartment. You notice the door is cracked.\n\nPress L to reach for the letter, D to push open the apartment door, or M to go back to the market.";
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.letter_0; }
        else if (Input.GetKeyDown(KeyCode.D)) { myState = States.apartmentDoor_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void apartmentDoor_0 ()
    {
        text.text = "\tYou try and push the door open but slip on something, hitting your head on the handrail. You look down and realize you slipped on the letter. Maybe you should open it?\n\nPress L to open the letter.";
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.letter_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void marketDoor_0()
    {
        text.text = "\tYou reach for the door handle and jiggle it but it is locked. You notice three small keyholes above the handle with a letter next to each keyhole: S G H. A light eminates from the back of the market and you think you can make out bottles of something on the shelves.\n\nPress A to return to the apartment or B to try and break in.";
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.apartment_0; }
        else if (Input.GetKeyDown(KeyCode.B)) { myState = States.break_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void break_0 ()
    {
        text.text = "\tYou do nothave anything to break the window with and nothing to pick the lock with. You try and punch the glass but you only end up hurting your fist.\n\nPress A to return to the apartment.";
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.apartment_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void letter_0 ()
    {
        text.text = "\tYou learn over and pickup the letter from under the doormat and slowly remove it from the envelope. On the back of the envelope you notice the word \"Trelos\" again. The letter is folded in half. You unfold it slowly and begin to read: \"To our dear un...\" it begins. However, within a few seconds, the words on the page become illegible.\n\nPress R to try and decipher the letter or G to give up.";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.letter_1; }
        else if (Input.GetKeyDown(KeyCode.G)) { myState = States.apartmentDoor_1; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void letter_1 ()
    {
        text.text = "\tYou squint and adjust the distance the letter is from your face, making out names that appear to begin with the letters S, G, and H. The only other words you can make out are \"Thank You\". The rest is illegible.\n\nPress T to throw the letter away in frustration.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.apartmentDoor_1; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void apartmentDoor_1 ()
    {
        text.text = "\tFrustrated, you crumple the letter up, throwing it at the apartment door as hard as you can. The letter hits the door with a loud, unnatural thud, causing it to swing open slowly. A long, dark hallway lies before you. Small lights come from the back of the hall.\n\nPress SPACE to continue.";
        if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Apartment"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

}
