using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
    
{
    
    public Text showText;
    public static int score;

    public Text timerText;
    public static float secondsCount;
    private int minuteCount;
    private int hourCount;

    public static int isVictory = 0;
    public GameObject canvas1;
    public Text showTextEnd;

    public Text timerTextEnd;
    void Start()
    {
        score = 0;
        secondsCount = 0;
        isVictory = 0;
        canvas1.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        showText.text = "Score: " + score;
        if(isVictory == 1)
        {
            showPanel();
        }
        UpdateTimerUI();
    }
    public void showPanel()
    {
        showTextEnd.text = "Score: " + score;
        timerTextEnd.text = hourCount.ToString("00") + ":" + minuteCount.ToString("00") + ":" + ((int)secondsCount).ToString("00");
        canvas1.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void UpdateTimerUI()
    {
        //set timer UI
        if(isVictory == 0)
        {
            secondsCount += Time.deltaTime;
        }
        
        //timerText.text = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s";
        if (hourCount > 0)
        {
            timerText.text = hourCount.ToString("00") + ":" + minuteCount.ToString("00") + ":" + ((int)secondsCount).ToString("00");
        }
        else
        {
            timerText.text =  minuteCount.ToString("00") + ":" + ((int)secondsCount).ToString("00");
        }
        
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }
}
