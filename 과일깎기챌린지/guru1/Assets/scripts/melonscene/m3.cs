using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class m3 : MonoBehaviour
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
        if (Input.GetKeyUp(KeyCode.RightArrow))
            SceneManager.LoadScene("m4");
        else if (Input.GetKeyUp(KeyCode.UpArrow))
            SceneManager.LoadScene("m1");
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
            SceneManager.LoadScene("m1");
        else if (Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("m1");
        else if (Input.GetKeyUp(KeyCode.DownArrow))
            SceneManager.LoadScene("m1");
    }
}
