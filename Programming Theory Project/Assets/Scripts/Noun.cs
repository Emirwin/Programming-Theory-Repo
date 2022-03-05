using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class Noun : WordBlock
{
    //POLYMORPHISM
    public override void DisplayWord()
    {
        additionalInfo = "is a Noun";
        if(isPlural)
        {
            additionalInfo += ". Plural.";
        }
        else
        {
            additionalInfo += ". Singular.";
        }
        base.DisplayWord();
        //currentWord = wordDisplay.GetComponent<TextMesh>().text;
        Debug.Log($"{currentWord} is a Noun");
    }

    //POLYMORPHISM
    public override void Pluralize()
    {
        base.Pluralize();

    }
}
