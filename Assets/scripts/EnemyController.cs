using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : EnemyScript {

    private int top = 3;
    private int buttom = -3;
    
    private bool positionY;

    private float nextFire = 0.0f;
    public float spawnRate;

    // Use this for initialization
    void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
        Movement();
        Shoot();
	}

    void Movement()
    {

        if (transform.position.y >= top)
        {
            positionY = true;
        } else if (transform.position.y <= buttom)
        {
            positionY = false;
        }

        if(positionY == true)
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        } else
        {
            transform.Translate(Vector2.up * Time.deltaTime);
        }
    }

    void Shoot()
    {
        if (Time.time >= nextFire)
        {
            nextFire += spawnRate;
            GameObject bullet = (GameObject)Instantiate(Resources.Load("Enemy"));
            bullet.transform.position = transform.position + Vector3.left * 0.35f;
            bullet.GetComponent<Rigidbody2D>().AddForce(transform.right * 1);
            Debug.Log("Shooting");
        }
        
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        base.OnTriggerEnter2D(coll);
    }

}
