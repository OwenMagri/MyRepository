using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncDecScript : MonoBehaviour
{
    int num = 50;
    // Use this for initialization
    void Start()
    {
        print("The starting number is " + num + ".");
        print("Press the UP arrow to add 1: Press the DOWN arrow to decrease 1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Adding the number by 1");
            num++;
            print("The new number is " + num);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Decreasing the number by 1");
            num--;
            print("The new number is " + num);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
