using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verb : WordBlock
{
    public new bool isPlural = true;
    public bool isNominalized = false;
    public override void DisplayWord()
    {
        //currentWord = wordDisplay.GetComponent<TextMesh>().text;
        if(!isNominalized){
            additionalInfo = "is a Verb";
            Debug.Log($"{currentWord} is a Verb");
        }
        else {
            additionalInfo = "is a Noun";
            Debug.Log($"{currentWord} is a Noun");
        }
        if(isPlural)
        {
            additionalInfo += ". Plural.";
        }
        else
        {
            additionalInfo += ". Singular.";
        }
        base.DisplayWord();
    }

    public override void OnMouseOver()
    {
        base.OnMouseOver();
        if(Input.GetKeyDown(KeyCode.C))
        {
            Nominalize();
        }
    }

    public override void Pluralize()
    {
        //base.Pluralize();
        if (!isPlural)
        {
            wordDisplay.GetComponent<TextMesh>().text = baseWord;
            isPlural = true;
        }
        else
        {
            wordDisplay.GetComponent<TextMesh>().text += "s";
            isPlural = false;
        }
    }

    public void Nominalize()
    {
        if(!isNominalized)
        {
            wordDisplay.GetComponent<TextMesh>().text += "ing";
            isNominalized = true;
        }
        else
        {
            wordDisplay.GetComponent<TextMesh>().text = baseWord;
            isNominalized = false;
        }
    }
}
