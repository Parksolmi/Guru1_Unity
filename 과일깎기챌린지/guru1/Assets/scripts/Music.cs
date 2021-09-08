using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject bgm;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
