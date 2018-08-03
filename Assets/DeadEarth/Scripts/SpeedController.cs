using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour {

    //private
    private Animator _controller = null;


    public float speed;


	// Use this for initialization
	void Start () {
        _controller = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        _controller.SetFloat("speed", speed);
	}
}
