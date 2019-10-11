using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropDownSelect : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public static Dropdown MyDropDown;
    public static Text MyChoice;

    // Update is called once per frame
    public void ShowChoice()
    {
        switch (MyDropDown.value)
        {
            case 1:
                SceneManager.LoadScene("MainLevel");
                break;
            case 2:
                SceneManager.LoadScene("MainLevelMeduim");
                break;
            case 3:
                SceneManager.LoadScene("MainLevelFast");
                break;
            default:
                MyChoice.text = "Please Select";
                break;
        }
    }
}
