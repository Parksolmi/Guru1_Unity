using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;

    public static int Point = 0;
    public GameObject ResultUI;
    public GameObject Board_s;
    public GameObject Board_f;

    public Text text_Point;

    public void ShowResult()
    {
        ResultUI.SetActive(true);
        if (Point >= 400.0f)
        {
            text_Point.text = "" + Mathf.Round(Point);
            Board_f.SetActive(false);
            Point = 0;
        }
        else
        {
            text_Point.text = "" + Mathf.Round(Point);
            Board_s.SetActive(false);
            Point = 0;
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1.0f;

        if (LimitTime <= 0.0f)
        {
            Time.timeScale = 0.0f;
            ShowResult();
        }
        else
        {
            LimitTime -= Time.deltaTime;
            text_Timer.text = "" + Mathf.Round(LimitTime);
        }
    }
}
