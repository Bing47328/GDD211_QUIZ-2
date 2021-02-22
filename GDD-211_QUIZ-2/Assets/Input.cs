using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Input : MonoBehaviour
{
    public InputField playerHandle;
    public InputField playerAge;
    public string playerName;
    public int myAge;

    public void setUp()
    {
        playerName = playerHandle.text;
        myAge = int.Parse(playerAge.text);
    }

    public void nextScene()
    {
        PlayerPrefs.SetString("ThisPlayer", playerName);
        PlayerPrefs.SetInt("ThisAge", myAge);
        SceneManager.LoadScene("Game");
    }
}
