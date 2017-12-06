using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endLine;

    private PlayerControl player;

    public bool isActive;
    private bool playerStop;

	// Use this for initialization
	void Start () {
        player = GetComponent<PlayerControl>();

        if(textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        DisableTextBox();

	}
	
	// Update is called once per frame
	void Update () {

        if(textLines == null)
        {
            return;
        }

        theText.text = textLines[currentLine];
        
        if(currentLine > endLine)
        {
            DisableTextBox();
        }
	}

    public void EnableTextBox()
    {
        textBox.SetActive(true);
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
    }

    public void ReloadScript(TextAsset textFile1)
    {
        if(textFile1 != null)
        {
            textLines = new string[1];
            textLines = (textFile1.text.Split('\n'));
        }
    }

}
