using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class WordBlock : MonoBehaviour
{
    public string baseWord;
    public string currentWord;
    public GameObject blockRender;
    public GameObject wordDisplay;
    protected SentenceHolder sentenceHolder;

    private Vector3 mouseOffset;
    private float mouseZCoord;

    //ENCAPSULATION
    private bool m_isPlural = false;
    public bool isPlural
    {
        get {return m_isPlural;}
        set {m_isPlural=value;}
    }

    protected string infoMessage, additionalInfo;
    // Start is called before the first frame update
    void Start()
    {
        wordDisplay.GetComponent<TextMesh>().text = baseWord;
        currentWord = baseWord;
        sentenceHolder = GameObject.Find("SentenceHolder").GetComponent<SentenceHolder>();
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

    public virtual void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Pluralize();
        }
    }

    //ABSTRACTION
    public virtual void DisplayWord()
    {
        //changes the Word child gameObject of the word block to the currentWord
        currentWord = wordDisplay.GetComponent<TextMesh>().text;
        infoMessage = $"{currentWord} {additionalInfo}";
        //Debug.Log(currentWord);
        sentenceHolder.displayInfo.GetComponent<TextMesh>().text = infoMessage;
    }

    //ABSTRACTION
    public virtual void Pluralize()
    {
        if (!m_isPlural)
        {
            wordDisplay.GetComponent<TextMesh>().text += "s";
            m_isPlural = true;
        }
        else
        {
            wordDisplay.GetComponent<TextMesh>().text = baseWord;
            m_isPlural = false;
        }
        
    }

    //ABSTRACTION
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
