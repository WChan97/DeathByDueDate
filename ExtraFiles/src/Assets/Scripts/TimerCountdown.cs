using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour {

    public float timeStart;
    public Text countdown;
	// Use this for initialization
	void Start () {
        countdown = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timeStart -= Time.deltaTime;
        countdown.text = timeStart.ToString("f0");
        print(timeStart);
	}
}
