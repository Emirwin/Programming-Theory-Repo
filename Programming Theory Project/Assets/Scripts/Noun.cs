using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noun : WordBlock
{
    public override void DisplayWord()
    {
        //base.DisplayWord();
        currentWord = wordDisplay.GetComponent<TextMesh>().text;
        Debug.Log($"{currentWord} is a Noun");
    }
}
