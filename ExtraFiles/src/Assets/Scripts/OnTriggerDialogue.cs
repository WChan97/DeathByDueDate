using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDialogue : MonoBehaviour
{

    public TextAsset theText;

    public int start;
    public int end;

    public TextBoxManager theTextBox;

    void Start()
    {
        theTextBox = FindObjectOfType<TextBoxManager>();
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player")
        {
            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = start;
            theTextBox.endLine = end;
            theTextBox.EnableTextBox();
        }
        
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if(other.name == "Player")
        {
            theTextBox.DisableTextBox();
        }
    }
}
