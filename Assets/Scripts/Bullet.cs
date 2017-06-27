using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed;
    

	// Use this for initialization
	void Start () {

        StartCoroutine(destroyLater(6.0f));
	}

    IEnumerator destroyLater(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        EnemySpaceShipMove ship = collider.GetComponent<EnemySpaceShipMove>();
        if (ship != null)
        {
            LevelController.current.onEnemyDestroy();
            Destroy(ship.gameObject);
            Destroy(this.gameObject);
        }
    }

    public void launch()
    {
        Rigidbody2D myBody = this.GetComponent<Rigidbody2D>();
        Vector2 vel = myBody.velocity;
        vel.y = speed;
        myBody.velocity = vel;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
