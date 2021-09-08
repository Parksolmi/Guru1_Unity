using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class change4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
            SceneManager.LoadScene("5");
        else if (Input.GetKeyUp(KeyCode.DownArrow))
            SceneManager.LoadScene("1");
        else if (Input.GetKeyUp(KeyCode.RightArrow))
            SceneManager.LoadScene("1");
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
            SceneManager.LoadScene("1");
        else if (Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("1");
    }
}
