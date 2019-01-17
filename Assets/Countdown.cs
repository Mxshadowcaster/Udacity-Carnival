using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineUI;
using System.Threading;

public class Countdown : MonoBehaviour {

public int timeLeft =60; //Seconds Overall
public int Text countdown; //UI Text Object

	void Start () {
                StartCoroutine("LoseTime");
                Time.timeScale = 1; //Ensures Timescale is right
	}
	
	
	void Update () {
		countdown.text = ("" + timeLeft); //Showing score on canvas
	}

        //Simple Coroutine
        IEnumerator LoseTime () {
                while (true) {
                        yield return new WaitForSeconds (1);
                        timeLeft--;
                }
        }
}
