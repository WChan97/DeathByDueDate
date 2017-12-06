using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScore : MonoBehaviour {

    public int points;
	void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<PlayerControl>() == null) return;

        ScoreSystem.pointsToAdd(points);

        Destroy (gameObject);
    }
}
