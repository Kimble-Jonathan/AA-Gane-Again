using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public static int number;
    public Text score;
    public Text highScore;
    public static string PlayerName;
    public InputField PlayernameInput;
    public Text Name;
    public Text LastScore;
    public Text Rounds;



    void Start()
    {
        highScore.text = PlayerPrefs.GetInt(PlayerName, 0).ToString();

        LastScore.text = PlayerPrefs.GetInt("score", number).ToString();

    }


    public void Update()
    {
        Name.text = PlayerName;

        number = Score.PinCount;
        score.text = number.ToString();
        PlayerPrefs.SetInt("score", number);

        if (number > PlayerPrefs.GetInt(PlayerName, 0))
        {
            PlayerPrefs.SetInt(PlayerName, number);
            highScore.text = number.ToString();
        }

    }
    public void Reset()
    {
        PlayerPrefs.DeleteKey(PlayerName);
        highScore.text = "0";
    }

    public void UpdateName()
    {

        PlayerName = PlayernameInput.text;
        PlayerPrefs.SetString(PlayerName.ToString(), PlayerName);


    }
}



