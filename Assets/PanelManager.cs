using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelManager : MonoBehaviour {

    public GameObject [] panels; // this is an array of the panels that you want the buttons to open/close

    string selectedMenu; // will hold the name of the tag on the pressed button

    // call this public method from the 'onClick()' function in the button component
    public void switchPanel () {

        selectedMenu = EventSystem.current.currentSelectedGameObject.tag;  // gets the tag (a string) from the button that was pressed

        // this loop will check every panel in the 'panel' array to see if it's name is the same 
        // as the tag on the button that was pressed
        for (int i = 0; i < panels.Length; i++)
        {
            // checks to see if the name of each panel is the same as the tag on the button that was just pressed
            if (panels[i].gameObject.name == selectedMenu)
            {
                panels[i].SetActive(!panels[i].activeSelf); // turns panel ON if it is OFF, and vice versa
            }

            else
            {
                panels[i].SetActive(false); // turns the correct panels off
            }

        }
    }
}
