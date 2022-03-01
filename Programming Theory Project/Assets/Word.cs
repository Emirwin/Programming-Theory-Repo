using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word : MonoBehaviour
{
    public string baseWord;
    public string currentWord;
    public GameObject blockRender;
    public GameObject wordDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        DisplayWord();
    }

    void DisplayWord()
    {
        //changes the Word child gameObject of the word block to the currentWord
        currentWord = wordDisplay.GetComponent<TextMesh>().text;
        Debug.Log(currentWord);
    }
}
