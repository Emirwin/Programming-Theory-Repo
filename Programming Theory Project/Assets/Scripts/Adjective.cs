using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class Adjective : WordBlock
{
    //POLYMORPHISM
    public override void DisplayWord()
    {
        //changes the Word child gameObject of the word block to the currentWord
        //currentWord = wordDisplay.GetComponent<TextMesh>().text;
        additionalInfo = "is an Adjective";
        base.DisplayWord();
        Debug.Log(infoMessage);
        
    }
}
