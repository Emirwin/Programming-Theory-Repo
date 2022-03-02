using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordBlock : MonoBehaviour
{
    public string baseWord;
    public string currentWord;
    public GameObject blockRender;
    public GameObject wordDisplay;

    private Vector3 mouseOffset;
    private float mouseZCoord;

    private bool isPlural = false;
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
        mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mouseOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        DragBlock();
    }

    public virtual void DisplayWord()
    {
        //changes the Word child gameObject of the word block to the currentWord
        currentWord = wordDisplay.GetComponent<TextMesh>().text;
        Debug.Log(currentWord);
    }

    public virtual void Pluralize()
    {
        if (!isPlural)
        {
            wordDisplay.GetComponent<TextMesh>().text += "s";
            isPlural = true;
        }
        else
        {
            wordDisplay.GetComponent<TextMesh>().text = baseWord;
            isPlural = false;
        }
        
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void DragBlock()
    {
        transform.position = GetMouseWorldPos() + mouseOffset;
    }
}
