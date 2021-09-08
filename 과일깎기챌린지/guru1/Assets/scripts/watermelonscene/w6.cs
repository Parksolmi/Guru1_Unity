using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class w6 : MonoBehaviour
{
    public GameObject _ResultUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _ResultUI.SetActive(true);

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
            SceneManager.LoadScene("w1");
        else if (Input.GetKeyUp(KeyCode.RightArrow))
            SceneManager.LoadScene("w1");
        else if (Input.GetKeyUp(KeyCode.DownArrow))
            SceneManager.LoadScene("w1");
        else if (Input.GetKeyUp(KeyCode.Space))
            SceneManager.LoadScene("w1");

    }
}
