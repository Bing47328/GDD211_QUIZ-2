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

        PlayerPrefs.SetString("ThisPlayer", playerName);
        PlayerPrefs.SetInt("ThisAge", myAge);
    }

    public void nextScene()
    {
        SceneManager.LoadScene("Game");
    }
}
