using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleUIHandler : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public 
    // Start is called before the first frame update
    // test
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            StartNew();
        }
    }

    void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
