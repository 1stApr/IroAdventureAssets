using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int[] p;
    public Text pointsText1;
    public Text pointsText2;
    public Text pointsText3;
    public Text pointsText4;
    public Text pointsText5;
    void Start()
    {
        p = new int[5];
        p[0] = 0;
        p[1] = 0;
        p[2] = 0;
        p[3] = 0;
        p[4] = 0;
        loadScore();
    }
    
    // Update is called once per frame
    public void UpdateUI()
    {
        loadScore();
        Array.Sort(p);
        SaveScore();
        pointsText1.text = "Points: " + p[4];
        pointsText2.text = "Points: " + p[3];
        pointsText3.text = "Points: " + p[2];
        pointsText4.text = "Points: " + p[1];
        pointsText5.text = "Points: " + p[0];
        
    }
    int getMin()
    {
        return p[4];
    }
    public static void loadScore()
    {
        if (PlayerPrefs.HasKey("ps0"))  // check if we already save It before
        {
            p[0] = PlayerPrefs.GetInt("ps0");
        }else
        {
            p[0] = 0;
        }

        if (PlayerPrefs.HasKey("ps1"))  // check if we already save It before
        {
            p[1] = PlayerPrefs.GetInt("ps1");
        }
        else
        {
            p[1] = 0;
        }

        if (PlayerPrefs.HasKey("ps2"))  // check if we already save It before
        {
            p[2] = PlayerPrefs.GetInt("ps2");
        }
        else
        {
            p[2] = 0;
        }

        if (PlayerPrefs.HasKey("ps3"))  // check if we already save It before
        {
            p[3] = PlayerPrefs.GetInt("ps3");
        }
        else
        {
            p[3] = 0;
        }

        if (PlayerPrefs.HasKey("ps4"))  // check if we already save It before
        {
            p[4] = PlayerPrefs.GetInt("ps4");
        }
        else
        {
            p[4] = 0;
        }
    }
    public void SaveScore()
    {
        PlayerPrefs.SetInt("ps0", p[0]);
        PlayerPrefs.SetInt("ps1", p[1]);
        PlayerPrefs.SetInt("ps2", p[2]);
        PlayerPrefs.SetInt("ps3", p[3]);
        PlayerPrefs.SetInt("ps4", p[4]);
        
    }
}
