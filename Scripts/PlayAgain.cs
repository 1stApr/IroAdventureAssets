using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void Reset()
    {
        //SceneManager.LoadScene("ObjectManipulation");
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLever(string lever)
    {
        Application.LoadLevel(lever);
    }
}
