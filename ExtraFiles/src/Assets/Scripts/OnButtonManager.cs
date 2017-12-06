using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonManager : MonoBehaviour {

    public GameObject deathCrack;
    public GameObject breakableObject;

    public bool isTrue;

    private PlayerControl player;

	// Use this for initialization
	void Start () {
        player = GetComponent<PlayerControl>();
        isTrue = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayerDies()
    {
        if (isTrue)
        {
            //player falls out
        }
    }

    public void ObjectDestroy()
    {
        if (isTrue)
        {
            Destroy(breakableObject);
        }

    }
}
