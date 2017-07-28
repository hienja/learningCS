using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom,
						corridor_0, corridor_1, corridor_2, closet, in_closet, floor,
						stair_0, stair_1, courtyard};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.cell) {
			cell();	
		} else if (myState == States.sheets_0) {
			sheets_0();
		} else if (myState == States.lock_0) {
			lock_0();
		} else if (myState == States.mirror) {
			mirror();
		} else if (myState == States.cell_mirror) {
			cell_mirror();
		} else if (myState == States.sheets_1) {
			sheets_1();
		} else if (myState == States.lock_1) {
			lock_1();
		} else if (myState == States.corridor_0) {
			corridor_0();
		} else if (myState == States.corridor_1) {
			corridor_1();
		} else if (myState == States.corridor_2) {
			corridor_2();
		} else if (myState == States.closet) {
			closet();
		}else if (myState == States.in_closet) {
			in_closet();
		}else if (myState == States.stair_0) {
			stair_0();
		}else if (myState == States.stair_1) {
			stair_1();
		}else if (myState == States.floor) {
			floor();
		}else if (myState == States.courtyard) {
			courtyard();
		}
	}
	
	void cell () {
		text.text = "You wake up and you find yourself in a prison cell. " +
					"You notice there is a bed, a mirror on a wall, and " +
					"the cell door is locked from the outside. You must " +
					"escape before someone notices you senpai.\n\n" +
					"Press S to view Sheets, M to view Mirror, or L to " +
					"view Lock.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
		if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		}
		if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		}
	}
	
	void sheets_0 () {
		text.text = "The conditions of the sheets are horrendous. You hope " +
					"you don't stay long enough to sleep on these things.\n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void sheets_1 () {
		text.text = "Looking at the sheets through the mirror still looks horrendous.\n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void lock_0 () {
		text.text = "You see a number pad just outside the cell door. " +
					"However the bars are blocking your view.  If only you had " +
					"something to help you see pass the bars.\n\n" + 
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void lock_1 () {
		text.text = "You are now able the clearly see the number pad . " +
					"You notice there are four fingerprint. There can only be so many " +
					"combinations. 24 maybe.\n\n" + 
					"Press R to Return to roaming your cell or Press O to Open the cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
		if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.corridor_0;
		}
	}
	
	void mirror () {
		text.text = "You notice that the mirror is loose. You grab the mirror.\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void cell_mirror () {
		text.text = "You're still in the cell but now you got this mirror. " +
					"You notice there is a bed, the wall that use to have a mirror, and " +
					"the cell door is still locked from the outside.\n\n" +
					"Press S to view Sheets or L to view Lock.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		}
		if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		}
	}
	
	void corridor_0 () {
		text.text = "You are now in a corridor. You see a staircase and a door.\n\n" +
					"Press S to go up the stairs, F to check the floor, or C to check the closet.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stair_0;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.floor;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet;
		}
	}
	
	void corridor_1 () {
		text.text = "You are still in the corridor. At least you got this paperclip.\n\n" +
					"Press S to go up the stairs or C to check the closet.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stair_1;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.in_closet;
		}
	}
	
	void corridor_2 () {
		text.text = "You in the corridor with your spefy new uniform.\n\n" +
					"Press S to go up the stairs.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.courtyard;
		}
	}
	
	void floor () {
		text.text = "You see a paperclip. You pick it up.\n\n" +
					"Press B to stand back up.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.corridor_1;
		}
	}
	
	void closet () {
		text.text = "The closet is locked.\n\n" +
					"Press B to go back to the corridor.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.corridor_0;
		}
	}
	
	void in_closet () {
		text.text = "You used the paperclip to pick the lock. Luckily you have that " +
					"skill or else the story wouldn't progress. You see a uniform and " +
					"you put it on.\n\n" +
					"Press B to go back to the corridor.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.corridor_2;
		}
	}
	
	void stair_0 () {
		text.text = "You go upstairs and see a courtyard. There are too many guards to pass though.\n\n" +
			"Press B to go back to the corridor.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.corridor_0;
		}
	}
	
	void stair_1 () {
		text.text = "There are still too many guards. At least you got this paperclip though.\n\n" +
			"Press B to go back to the corridor.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.corridor_1;
		}
	}
	
	void courtyard () {
		text.text = "You were able to walk pass the guards. Now you can move on with your life.\n\n" +
			"Press P to Play again.";
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell;
		}
	}
}
