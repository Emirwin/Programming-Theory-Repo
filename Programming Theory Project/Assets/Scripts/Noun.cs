using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noun : WordBlock
{
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

    public override void Pluralize()
    {
        base.Pluralize();

    }
}
