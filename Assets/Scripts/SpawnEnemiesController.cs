using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesController : MonoBehaviour {
    public static SpawnEnemiesController current;

    public GameObject prefabEnemyShip;
    public GameObject prefabEnemyBomb;
    public float spawnDelta;
    float last_spawn = 0;

	// Use this for initialization
	void Start () {
        current = this;
	}

    bool spawnTime()
    {
        return Time.time - last_spawn > spawnDelta;
    }

    void launchShip()
    {
        if (spawnTime())
        {
            GameObject obj = GameObject.Instantiate(this.prefabEnemyShip);
            obj.transform.position = this.transform.position;
            float xSpawn = Random.Range(-5.0f, 5.0f);
            Vector3 tmp = new Vector3(xSpawn, 0, 0);
            obj.transform.position += tmp;
            last_spawn = Time.time;
        }
    }
	
	// Update is called once per frame
	void Update () {
        this.launchShip();
	}
}
