using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {

    public Score scoreTracker;
    public int scoreValue = 1;


		
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //only act if it is the PLAYER triggering the item
        if (collision.GetComponent<Player>())

            //change the score by how much it is valued
            scoreTracker.ChangeValue(scoreValue);

            //die
            Destroy(gameObject);

    }
    

}
