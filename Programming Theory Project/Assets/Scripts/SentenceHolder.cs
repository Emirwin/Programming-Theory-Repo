using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceHolder : MonoBehaviour
{
    public GameObject displayInfo;
    void DisplayInfo(string info)
    {
        //change the DisplayInfo to the object's Tag
        displayInfo.GetComponent<TextMesh>().text = info;
    }
}
