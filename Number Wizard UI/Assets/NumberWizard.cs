using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed = 8;
	
	public Text text;
	
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		text.text = guess.ToString();
	}
	
	public void GuessHigher(){
		min = guess + 1 > max ? max : guess + 1;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess - 1 < min ? min : guess - 1;
		NextGuess();
	}
	
	void NextGuess () {
		guess = Random.Range (min, max);
		text.text = guess.ToString();
		--maxGuessesAllowed;
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}
