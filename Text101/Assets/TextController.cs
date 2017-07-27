using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.cell) {
			state_cell();	
		} else if (myState == States.sheets_0) {
			state_sheets_0();
		} else if (myState == States.lock_0) {
			state_lock_0();
		} else if (myState == States.mirror) {
			state_mirror();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror();
		} else if (myState == States.sheets_1) {
			state_sheets_1();
		} else if (myState == States.lock_1) {
			state_lock_1();
		} else if (myState == States.freedom) {
			state_freedom();
		}
	}
	
	void state_cell () {
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
	
	void state_sheets_0 () {
		text.text = "The conditions of the sheets are horrendous. You hope " +
					"you don't stay long enough to sleep on these things.\n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void state_sheets_1 () {
		text.text = "Looking at the sheets through the mirror still looks horrendous.\n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_0 () {
		text.text = "You see a number pad just outside the cell door. " +
					"However the bars are blocking your view.  If only you had " +
					"something to help you see pass the bars.\n\n" + 
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void state_lock_1 () {
		text.text = "You are now able the clearly see the number pad . " +
					"You notice there are four fingerprint. There can only be so many " +
					"combinations. 24 maybe.\n\n" + 
					"Press R to Return to roaming your cell or Press O to Open the cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
		if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.freedom;
		}
	}
	
	void state_mirror () {
		text.text = "You notice that the mirror is loose. You grab the mirror.\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void state_cell_mirror () {
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
	
	void state_freedom () {
		text.text = "You've escaped! Now you can move on with your life.\n\n" +
					"Press P to Play again.";
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell;
		}
	}
}
