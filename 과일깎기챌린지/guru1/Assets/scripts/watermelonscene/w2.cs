using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class w2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("w3");
        else if (Input.GetKeyUp(KeyCode.UpArrow))
            SceneManager.LoadScene("w1");
        else if (Input.GetKeyUp(KeyCode.RightArrow))
            SceneManager.LoadScene("w1");
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
            SceneManager.LoadScene("w1");
        else if (Input.GetKeyUp(KeyCode.DownArrow))
            SceneManager.LoadScene("w1");
    }
}
