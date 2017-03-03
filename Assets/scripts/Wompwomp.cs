using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wompwomp : EnemyScript {

	// Use this for initialization
	void Start () {
        base.Start();

	}
	
	// Update is called once per frame
	void Update () {
		base.Update();
	}

    public void OnTriggerEnter2D(Collider2D coll){
        base.OnTriggerEnter2D(coll);
    }
}
