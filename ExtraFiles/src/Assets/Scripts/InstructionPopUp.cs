using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPopUp : MonoBehaviour {

    private Renderer sprite;
	    
    void Start()
    {
        sprite = GetComponent<Renderer>();

       /* if (isActive)
        {
            Enable();
        }
        else
        {
            Disable();
        }*/
    }
    public void Enable()
    {
        sprite.enabled = true;
    }

    public void Disable()
    {
        sprite.enabled = false;
    }
}
