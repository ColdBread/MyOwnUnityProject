using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemyZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        EnemySpaceShipMove ship = collider.GetComponent<EnemySpaceShipMove>();
        if (ship != null)
        {
            HeroController.current.removeHealth();
            Destroy(ship.gameObject);
            
        }
    }
}
