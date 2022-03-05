using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class Copula : WordBlock
{
    //POLYMORPHISM
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
    //POLYMORPHISM
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
