using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MarketTextController : MonoBehaviour {

    public Text text;
    private enum States { street_0, market_0, market_1, market_2, market_3, park_0, bench_0, lamp_0, register_0, light_0, light_1, light_2, food_0, underBench_0, underBench_1, note_1, note_2};
    private States myState;

    void Start()
    {
        myState = States.street_0;
    }

    void Update()
    {
        if (myState == States.street_0) { street_0(); }
        else if (myState == States.market_0) { market_0(); }
        else if (myState == States.market_1) { market_1(); }
        else if (myState == States.market_2) { market_2(); }
        else if (myState == States.market_3) { market_3(); }
        else if (myState == States.park_0) { park_0(); }
        else if (myState == States.bench_0) { bench_0(); }
        else if (myState == States.lamp_0) { lamp_0(); }
        else if (myState == States.register_0) {  register_0(); }
        else if (myState == States.light_0) { light_0(); }
        else if (myState == States.light_1) { light_1(); }
        else if (myState == States.light_2) { light_2(); }
        else if (myState == States.food_0) { food_0(); }
        else if (myState == States.underBench_0) { underBench_0(); }
        else if (myState == States.underBench_1) { underBench_1(); }
        else if (myState == States.note_1) { note_1(); }
        else if (myState == States.note_2) { note_2(); }
    }

    void street_0()
    {
        text.text = "\tAs you turn around and walk through the doorway you realize you are back in the street, with the apartment behind you. You glance at the apartment door and notice the door is closed and locked. You notice there is a light in the market window up the road to your left. The park is to the right.\n\nPress P to go to the park or M to go to the market.";
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.park_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void market_0()
    {
        text.text = "\tYou approach the market, noting the name: The Promised Land. The ornate design reminds you of something from the past. You approach the door and look through the glass. A light seems to move toward the back of the market and you think you can make out the silhouette of a person.\n\nPress K to unlock the door and enter the market or P to go to the park.";
        if (Input.GetKeyDown(KeyCode.K)) { myState = States.market_1; }
        else if (Input.GetKeyDown(KeyCode.P)) { myState = States.park_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void park_0()
    {
        text.text = "\tYou decided to hobble back to the park. Thunder rolls again in the distance. You think you hear voices in it. You're probably just tired. The park bench where you awoke earlier is before you. The park behind is dark and ominous. The trees rustle restlessly in the wind. It's cool outside.\n\nPress S to sit down on the bench or M to go to the market.";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.bench_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void bench_0()
    {
        text.text = "\tYou take a seat on the bench and let out a deep sigh and close your eyes. The wind caresses your face gently. You think you hear a steady beeping sound in the distance. You open your eyes and notice that the lamp from earlier fickers and nearly goes out. You feel compelled to go towards the market.\n\nPress L to go the Lamp, G to look under the bench, or M to go to the market.";
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.lamp_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.G)) { myState = States.underBench_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void lamp_0 ()
    {
        text.text = "\tYou walk over to the lamp. Its yellowish glow turns to a bright white as you look into it. You turn away quickly as it hurts your eyes. The image of a face almost appears as you blink quickly trying to refocus in the dim lighting conditions around you.\n\nPress M to go to the Market.";
        if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }
     
    void market_1 ()
    {
        text.text = "\tYou push each key into the keyholes. Upon supplying the final key, a mechanism in the door is activated, causing all three to turn at once and unlock the door. You push the door open slowly and step inside and glance around. A light in a hallway in the back flickers with white light.\n\nPress Space to continue.";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.market_2; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void market_2 ()
    {
        text.text = "\tThe floors are again made of wood, only lighter this time. The shelves are filled with chocolate milk. The only light illuminating the scene is coming from the back of the market. You see faint silhouettes of people in your peripheral vision but when you look at in that direction, they disappear.\n\nPress R to go to the register or L to go towards the light.";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.register_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.light_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void market_3()
    {
        text.text = "\tYou hobble back to the entrance of the market and look around.\n\nPress R to go back to the register or L to walk towards the light.";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.register_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.light_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void register_0()
    {
        text.text = "\tYou hobble slowly toward the register. You notice bags full of interesting foods. You look at the signage around the register and realize it is all written in an Asian language you do not know. There is a credit card on the counter but the name is obscured.\n\nPress F to take a food item and examine it more closely, L to go towards the light, or M to walk back to the market entrance.";
        if (Input.GetKeyDown(KeyCode.F)) { myState = States.food_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_3; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.light_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void light_0()
    {
        text.text = "\tYou hobble slowly toward the light in the back of the market. It seems rather ordinary. A hallway appears before you. You see the restroom further down the hall as well as an area for employees.\n\nPress W to walk up to the light or M to walk back to the market entrance.";
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.light_1; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_3; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void food_0()
    {
        text.text = "\tYou reach in and pull out two items. The first is frozen octopus. The second is some kind of marianted meat. Neither are ready for consumption. Your stomach rumbles. You cannot remember the last time you ate. You place the food items back in their bags.\n\nPress L to go towards the light or M to go back to the Market entrance.";
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.light_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_3; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void underBench_0()
    {
        text.text = "\tYou spontanesouly decide to look under the bench. Beneth it is a rectangular box, big enough to fit in your lap.\n\nPress G to grab the box, L to get up and go to the lamp, or M to go toward the market.";
        if (Input.GetKeyDown(KeyCode.G)) { myState = States.underBench_1; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lamp_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void underBench_1()
    {
        text.text = "\tYou reach down, pick up the box, and place it in your lap. It is made of hard plastic with two latches on the side. The letters SIG appear on the front. You flip each latch up and open the lip of the box. Inside you see the outline shape of a pistol in foam. There are two small notes inside.\n\nPress L to examine note 1 and A to examine note 2.";
        if (Input.GetKeyDown(KeyCode.L)) { { myState = States.note_1; } }
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.note_2; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void note_1()
    {
        text.text = "\tYou take the first small note. It is written on lined paper. The only words that appear on it are: We had a deal. It is signed with an L.\n\nPress A to look at the second note or M to put the box back and go to the market.";
        if (Input.GetKeyDown(KeyCode.A)) { { myState = States.note_2; } }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void note_2()
    {
        text.text = "\tYou take the second small note. It is written on a green sticky note. You see a drawing of a person with very wide outstretched arms. It is signed with an A.\n\nPress L to look at the first note or M to put the box back and go to the market.";
        if (Input.GetKeyDown(KeyCode.L)) { { myState = States.note_1; } }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.market_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void light_1()
    {
        text.text = "\tAs you hobble towards the light, your body begins to ache and your eyes begin to burn from the brightness of the light. You stop for a moment and realize that the next few steps will take all your strength and energy.\n\nPress P to push forward inspite of the pain or M to go back to the market.";
        if (Input.GetKeyDown(KeyCode.P)) { { myState = States.light_2; } }
        else if (Input.GetKeyDown(KeyCode.M)) { { myState = States.market_3; } }
            else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void light_2()
    {
        text.text = "\tYou press on, defying your aching body and burning eyes. You hear a faint beeping sound begin to grow steadily louder and the muffled sound of voices around you. Someone is breathing heavily. There is a force that tries to pull you back away from the light but you press on against all reason and hope, pressing through the pain and breaking through into another place...\n\nPress Space to continue...";
        if (Input.GetKeyDown(KeyCode.Space)) { { SceneManager.LoadScene("Final"); } }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

}
