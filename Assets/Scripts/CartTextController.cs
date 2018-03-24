using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CartTextController : MonoBehaviour {

	public Text text;
	private enum States {cart_0, photo_0, water_0, water_1, food_0, stick_0, letter_0, letter_1, photo_0cont};
	private States myState;
	
	void Start () 
	{
		myState = States.cart_0;
	}
	
	void Update () 
	{	
		if 		(myState == States.cart_0) {cart_0();}
		else if (myState == States.photo_0) {photo_0();}
        else if (myState == States.photo_0cont) { photo_0cont();}
		else if (myState == States.water_0) {water_0();}
		else if (myState == States.water_1) {water_1();}
		else if (myState == States.food_0) {food_0();}
		else if (myState == States.stick_0) {stick_0();}
		else if (myState == States.letter_0) {letter_0();}
        else if (myState == States.letter_1) { letter_1();}
	
	}

	void cart_0 () 
	{
		text.text = "\tLooking into the cart you take a quick inventory of the items there: an unopened letter, an old photo, a blue water bottle, a walking stick, and some food wrappers that may have left overs in them. The photo and the letter are in a small torn up cardboard box. You cannot remember how you received them.\n\nP to look at the Photo, W to look at the Water Bottle, F to look at Food Wrappers, S to look at Walking Stick, L to pick up the Letter.";
		if		(Input.GetKeyDown(KeyCode.P)) {myState = States.photo_0;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.water_0;}
		else if (Input.GetKeyDown(KeyCode.F)) {myState = States.food_0;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.stick_0;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.letter_0;}	
		else if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		else	{}
	}
	
	void photo_0 () 
	{
		text.text = "\tYou pick up the photo and turn it over in your hand. On the back of the photo the words \"ΤRELOS 3/5/15\" are written. On the front is a picture of four individuals: an older man of average height in his late twenties or early thirties with brown hair, a darker skinned and dark haired boy standing next to him, a young girl, the shortest one in the group, with long chestnut colored hair, and another young boy with short blond hair. Everyone is smiling.\n\nPress SPACE to continue.";
		if		(Input.GetKeyDown(KeyCode.Space)) {myState = States.photo_0cont;}
		else if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		else	{}
	}

    void photo_0cont ()
    {
        text.text = "\tAs you look at the picture, you find yourself smiling with them. They all seem so familiar to you.  You place the photo back in its box in the cart and look at the other items in your cart.\n\nP to look at the Photo, W to look at the Water Bottle, F to look at Food Wrappers, S to look at Walking Stick, L to pick up the Letter.";
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.photo_0; }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.water_0; }
        else if (Input.GetKeyDown(KeyCode.F)) { myState = States.food_0; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.stick_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.letter_0; }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }
	
	void water_0 () 
	{
		text.text = "\tYou pick up your blue water bottle and check the water level. It is half empty with a liquid that looks like it might have been clear at one point in time. The bottle itself is well used with scratches all over the blue tinted surface. You are not sure why but this bottle holds a special place in your heart.\n\nP to put the bottle back in the cart or D to take a swig of the liquid.";
		if		(Input.GetKeyDown(KeyCode.P)) {myState = States.cart_0;}
		else if (Input.GetKeyDown(KeyCode.D)) {myState = States.water_1;}
		else if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		else	{}
	}
	
	void water_1 () 
	{
		text.text = "\tYou take a swig of the liquid and begin to cough almost immediately. The water is lukewarm and has the taste of backwash mixed with unbrushed teeth. You place the water bottle back into the cart.\n\nP to look at the Photo, W to look at the Water Bottle, F to look at Food Wrappers, S to look at Walking Stick, L to pick up the Letter.";
		if		(Input.GetKeyDown(KeyCode.P)) {myState = States.photo_0;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.water_0;}
		else if (Input.GetKeyDown(KeyCode.F)) {myState = States.food_0;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.stick_0;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.letter_0;}	
		else if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		else	{}
	}
	
	void food_0 () 
	{
		text.text = "\tYour stomach rumbles a bit and you wonder when was the last time you had anything to eat. You glance at the food wrappers in the cart and but they are empty. You are not sure why you kept them. Maybe you did not want to litter but could not find a proper trash receptacle? Perhaps a local dumpster has some leftovers…\n\nP to look at the Photo, W to look at the Water Bottle, F to look at Food Wrappers, S to look at Walking Stick, L to pick up the Letter.";
		if		(Input.GetKeyDown(KeyCode.P)) {myState = States.photo_0;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.water_0;}
		else if (Input.GetKeyDown(KeyCode.F)) {myState = States.food_0;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.stick_0;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.letter_0;}	
		else if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		else	{}
	}
	
	void stick_0 () 
	{
		text.text = "\tYou pick up the walking stick. It is an old oak walking stick, smooth and worn by heavy usage. It is the only thing you own that isn’t damaged in any way. You place the stick back in the cart.\n\nP to look at the Photo, W to look at the Water Bottle, F to look at Food Wrappers, S to look at Walking Stick, L to pick up the Letter.";
		if		(Input.GetKeyDown(KeyCode.P)) {myState = States.photo_0;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.water_0;}
		else if (Input.GetKeyDown(KeyCode.F)) {myState = States.food_0;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.stick_0;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.letter_0;}	
		else if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		else	{}
	}
	
	void letter_0 () 
	{
		text.text = "\tYou pick up the unopened letter and turn it over in your hand. The material feels dried, like old paper. The white of the envelope is tinted yellow from the passage of time. On the front a name is written but illegible.\n\n Press Space to continue...";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.letter_1;}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }

    void letter_1()
    {
        text.text = "\tYOu move the letter to your right hand and slide the thumb of your left under the once sticky seal. It opens easily. As you reach into the envelope to pull out the letter, a strong gust of wind tears the envelope from your grasp and sends it flying down the cobblestone street to the west.\n\n Press SPACE to go after it...";
        if (Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("Street"); }
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else { }
    }
	
}
		