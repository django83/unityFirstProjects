using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

    public float rotatingSpeed = 3.0f;

	// Use this for initialization
	void Start () {
        Debug.Log("Spinning Started!");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Spinning with speed of " + rotatingSpeed);
        transform.Rotate(0, rotatingSpeed, 0);
        //transform.Rotate(rotatingSpeed, 0, 0);
        //transform.Rotate(0, 0, rotatingSpeed);
    }
}
