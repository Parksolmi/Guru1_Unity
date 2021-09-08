using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class Result : MonoBehaviour
{
    public GameObject _ResultUI;
    public GameObject _success;
    public GameObject _failure;

    public float Point = 500; // 점수 임의 설정
    public Text text_Point;

    public void ShowResult()
    {
        _ResultUI.SetActive(true);
        if (Point >= 400.0f)
        {
            text_Point.text = "" + Mathf.Round(Point);
            _success.SetActive(true);
        }
        else
        {
            text_Point.text = "" + Mathf.Round(Point);
            _failure.SetActive(true);
        }
        Time.timeScale = 0.0f;
    }
}
