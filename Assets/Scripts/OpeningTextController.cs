using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class OpeningTextController : MonoBehaviour {

	public Text text;
	private enum States {opening, bench_0, bench_1, rollOver_0, cart_0, cart_1, sitUp_0, lamp_0};
	private States myState;
	
	void Start () 
	{
		myState = States.opening;
	}
	
	void Update () 
	{	
		if 		(myState == States.opening) {opening();} 
		else if (myState == States.bench_0) {bench_0();}
		else if (myState == States.bench_1) {bench_1();}
		else if (myState == States.rollOver_0) {rollOver_0();}
		else if (myState == States.cart_0) {cart_0();}
		else if (myState == States.cart_1) {cart_1();}
		else if (myState == States.sitUp_0) {sitUp_0();}
		else if (myState == States.lamp_0) {lamp_0();}
	
	}

	void opening () 
	{
		text.text = "\tYou awake one dark and stormy night on a park bench. You feel cold, chilled by the eastern wind and dissatisfied with the old newspapers you have been using as blankets. Flies buzz over your head. As the wind blows, the leaves of nearby trees rustle with anxiety. You take a deep breath and inhale the scent of the unwashed. You fling your head back, gagging and coughing loudly as you almost choke on the smell. As the coughing stops, you squint and look up at the sky and then take in your surroundings. It is dark. There is an old streetlamp nearby giving off an ugly yellowish light. \n\nPress SPACE to continue...";
		if		(Input.GetKeyDown(KeyCode.Space)) {myState = States.bench_0;}
		else if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		else	{}
	}
	
	void bench_0 ()
	{
		text.text = "\tYou shift slowly on the park bench. While you are average height, this park bench is particularly small. Your feet hang off the edge of the bench and are uncovered by the newspapers currently draped over your shoulders. Your boots are little more than two pieces of worn leather sewn together. You reach up to scratch your face and almost lose your hand in the ragged and dirty beard adorning your face.  Thunder sounds in the distance. You glance at a shopping cart that you know belongs to you. Something tells you the cart is important.\n\nPress R to rollover, C to go to your cart, or S to sit up.";
		if		(Input.GetKeyDown(KeyCode.R)) {myState = States.rollOver_0;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cart_0;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.sitUp_0;}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else	{}
	}
	
	void rollOver_0 ()
	{
		text.text = "\tYou roll over on the hard wooden bench and try to go back to sleep. However, the sound of rolling thunder in the distance and a brief flash of light tell you that you will not be sleeping much tonight. As the thunder rolls a strong sensation washes over you and almost reminds you of something. Your cart squeaks as it continues to roll away from you slowly.\n\nPress C to go to your cart or S to sit up.";
		if      (Input.GetKeyDown(KeyCode.C)) { myState = States.cart_0;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.sitUp_0;}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else	{}
	}
	
	void cart_0()
	{
		text.text = "\tYour laziness gets the better of you again and you reach for your cart. As you extend your left hand out to grab it you almost fall off the bench face first. Catching yourself just in time, you manage to push yourself back onto your wooden park bench. It is highly unlikely that you will reach the cart from this position.\n\nPress R to rollover or S to sit up.";
		if		(Input.GetKeyDown(KeyCode.R)) {myState = States.rollOver_0;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.sitUp_0;}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else	{}
	}
	
	void sitUp_0 ()
	{
		text.text = "\tYou force yourself up onto an elbow and then into a seated position. Your knees and back are sore. As you run a callous, dirty hand through your dark brown hair, you glance at the dim yellow street lamp and then back at your cart.\n\nPress L to go to the lamp or C to go to your cart.";
		if		(Input.GetKeyDown(KeyCode.L)) {myState = States.lamp_0;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cart_1;}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else	{}
	}
	
	void lamp_0 ()
	{
		text.text = "\tStanding slowly, you limp towards the yellow street lamp. You lean yourself against the poll and take a deep breath. For a second, you think you hear the sound of a voice. You quickly glance over your shoulder and then around the scene. You are alone. You are standing on a cobblestone road somewhere... You cannot remember where you are. You glance up at the lamp and the light seems to brighten for just a second with a cloudly face before fading again.\n\nPress B to go back to the park bench or C to go to your cart.";
		if		(Input.GetKeyDown(KeyCode.B)) {myState = States.bench_1;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cart_1;}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else	{}
	}
	
	void bench_1 ()
	{
		text.text = "\tYou head back to the bench and take a seat to rest. Your cart is still rolling away slowly. \n\nPress L to go back to the lamp or C to go to your cart.";
		if		(Input.GetKeyDown(KeyCode.L)) {myState = States.lamp_0;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cart_1;}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
        else	{}
	}
	
	void cart_1 () 
	{
		text.text = "\tYou stand up and hobble slowly towards the cart. As you reach the cart, you place your left hand on it to steady yourself and stop the carts movement. Looking into the cart you take a quick inventory of the items there: an unopened letter, an old photo, a blue water bottle, a walking stick, and some food wrappers that may have left overs in them. The photo and the letter are in a small torn up cardboard box. You struggle to remember how you got them. \n\n Press Space to go to contine.";
		if 		(Input.GetKeyDown(KeyCode.Space)) {SceneManager.LoadScene("Cart");}
        else if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("Menu"); }
    }

}
		