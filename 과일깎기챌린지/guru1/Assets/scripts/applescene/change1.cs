using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change1 : MonoBehaviour
{
    //AudioSource audio;
    //AudioSource audio = gameObject.GetComponent<AudioSource>();

    // Start is called before the first frame update
    void Start()
    {
        //AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        //AudioSource audio = gameObject.AddComponent<AudioSource>();
        //AudioSource audio = gameObject.GetComponent<AudioSource>();

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            //audio.Play();
            SceneManager.LoadScene("2");
        }
        else if(Input.GetKeyUp(KeyCode.UpArrow))
            SceneManager.LoadScene("1");
        else if (Input.GetKeyUp(KeyCode.RightArrow))
            SceneManager.LoadScene("1");
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
            SceneManager.LoadScene("1");
        else if (Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("1");
    }
}
