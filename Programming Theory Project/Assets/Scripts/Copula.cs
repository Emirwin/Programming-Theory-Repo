using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copula : WordBlock
{
    public override void DisplayWord()
    {
        additionalInfo = "is a linking verb";
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
        Debug.Log($"{currentWord} is a Verb");
    }

    public override void Pluralize()
    {
        if (!isPlural)
        {
            wordDisplay.GetComponent<TextMesh>().text = "are";
            isPlural = true;
        }
        else
        {
            wordDisplay.GetComponent<TextMesh>().text = baseWord;
            isPlural = false;
        }
        
    }
}
