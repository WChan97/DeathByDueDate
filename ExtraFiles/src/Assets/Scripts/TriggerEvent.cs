using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

    public GameObject interactiveObject;

    public TextAsset theText;

    public int startLine;
    public int endLine;

    private OnButtonManager interactManager;
    private TextBoxManager textBox;
    private bool waitForPress;
    // Use this for initialization
    void Start () {
        interactManager = FindObjectOfType<OnButtonManager>();
        textBox = FindObjectOfType<TextBoxManager>();
    }
	
	// Update is called once per frame
	void Update () {



        if (waitForPress && Input.GetKeyDown(KeyCode.F))
        {
            if (interactiveObject.name == "DestroyItem")
            {
                Destroy(interactiveObject);
                //interactManager.isTrue = true;
                //interactManager.ObjectDestroy();
            }
            if (interactiveObject.name == "DeathCrack")
            {
                interactManager.isTrue = true;
                interactManager.PlayerDies();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
                waitForPress = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            waitForPress = false;
        }
    }
}
