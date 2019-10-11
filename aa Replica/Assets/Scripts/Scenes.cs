using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{

    public float Rounds=0;
    public Text RoundsText;
   public void StartPlay()
    {
        Rounds = PlayerPrefs.GetFloat("Round", Rounds);
        Rounds +=  1;
        PlayerPrefs.SetFloat("Round", Rounds);
        
        SceneManager.LoadScene("MainLevel");
        
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ExitGame()
    {
 
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Update()
    {
        
        RoundsText.text = PlayerPrefs.GetFloat("Round", 0).ToString();
    }
}
