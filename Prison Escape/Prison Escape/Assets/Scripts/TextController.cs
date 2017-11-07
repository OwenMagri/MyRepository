using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0, floor, closet_door, corridor_1, stairs_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard}

    public Text myText;

    States myState;

	// Use this for initialization
	void Start () {

        myState = States.cell;

	}
	
	// Update is called once per frame
	void Update () {

        if (myState == States.cell) { Cell(); }
        else if (myState == States.mirror) { Mirror(); }
        else if (myState == States.lock_0) { Lock_0(); }
        else if (myState == States.sheets_0) { Sheets_0(); }
        else if (myState == States.cell_mirror) { Cell_Mirror(); }
        else if (myState == States.sheets_1) { Sheets_1(); }
        else if (myState == States.lock_1) { Lock_1(); }
        else if (myState == States.corridor_0) { corridor_0(); }
        else if (myState == States.stairs_0) { stairs_0(); }
        else if (myState == States.floor) { floor(); }
        else if (myState == States.closet_door) { closet_door(); }
        else if (myState == States.corridor_1) { corridor_1(); }
        else if (myState == States.stairs_1) { stairs_1(); }
        else if (myState == States.in_closet) { in_closet(); }
        else if (myState == States.corridor_2) { corridor_2(); }
        else if (myState == States.stairs_2) { stairs_2(); }
        else if (myState == States.corridor_3) { corridor_3(); }
        else if (myState == States.courtyard) { courtyard(); }
    }

    void Cell()
    {
        myText.text = "You are in a prison cell and you want to escape. \nThere are some dirty sheets on the bed, " +
        "a mirror on the wall, and the door is locked from outside.\n\n" +
        "Press S to view the sheets, M to view the mirror and L to view the Lock.";

        if (Input.GetKeyDown(KeyCode.S))      { myState = States.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.mirror;}
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_0;}
    }

    void Sheets_0()
    {
        myText.text = "These sheets are very dirty!" +
            "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }

    }


    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the" +
            " combination is. You wish you could somehow see where the dirty fingerprints" +
            " were." +
            "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Mirror()
    {
        myText.text = "That dirty old mirror on the wall seems loose!" +
            "\n\nPress T to take the mirror, or R to return back to the middle of the cell";

        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cell_mirror; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Cell_Mirror()
    {
        myText.text = "You are still in the your cell and you still want to escape!" +
            " Again, there are some dirty sheets on the bed and the cell door which is firmly" +
            " locked." +
            "\n\nPress S to view the sheets, or L to view the lock.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets_1; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_1; }
    }
    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand, won't make the sheets look any better" +
            "\n\nPress R to return back to the middle of the cell";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars and turn it round to see the lock." +
            "You can now see the fingerprints on the buttons." +
            "You enter the code correctly and the door unlocks!" +
            "\n\nPress O to open, or R to return back to the cell.";

        if (Input.GetKeyDown(KeyCode.O)) { myState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void corridor_0()
    {
        myText.text = "You have escaped the cell and find yourself in the corridor" +
            " You see stairs, a dirty floor and a closet door." +
            "\n\nPress S to go to the stairs, F to check the dirty floor, or C to check the closet door.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_0; }
        else if (Input.GetKeyDown(KeyCode.F)) { myState = States.floor; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.closet_door; }
    }

    void stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider." +
            "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip." +
            "\n\nPress P to pick up the hairclip, or R to return to the center of the corridor.";

        if (Input.GetKeyDown(KeyCode.P)) { myState = States.corridor_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void closet_door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
            "Maybe you could find something around to help enourage it open?" +
            "\n\nPress R to return to the corridor";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
            "Now what? You wonder if that lock on the closet would succumb to " +
            "to some lock-picking?" +
            "\n\nPress S to go to the stairs, or C to go to the closet.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_1; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.in_closet; }
    }

    void stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
            "confidence to walk out into a courtyard surrounded by armed guards!" +
            "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_1; }
    }

    void in_closet()
    {
        myText.text = "You unlock the closet and inside the closet you see a cleaner's uniform that looks about your size! " +
           "Seems like your day is looking-up." +
           "\n\nPress R to return to the corridor, or W to wear the uniform";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_2; }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.corridor_3; }
    }

    void corridor_2()
    {
        myText.text = "You leave the uniform in the closet and you're back to the corridor." +
            "\n\nPress S to go to the stairs, or C to go back to the closet";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_2; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.in_closet; }
    }

    void stairs_2()
    {
        myText.text = "You're at the stairs, still not confident into walking into the courtyard." +
            "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_2; }
    }

    void corridor_3()
    {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner." +
            "You strongly consider the run for freedom." +
            "\n\nPress S to go to the stairs or U to undress the uniform.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.courtyard; }
        else if (Input.GetKeyDown(KeyCode.U)) { myState = States.in_closet; }
    }

    void courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
            "The guard tips his hat at you as you waltz past, claiming " +
            "your freedom. You heart races as you walk into the sunset.\n\n" +
            "Press P to Play again.";

        if (Input.GetKeyDown(KeyCode.P)) { myState = States.cell; }
    }
}
