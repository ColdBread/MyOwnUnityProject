using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroController : MonoBehaviour {
    public float speed;
    public Animator animator;

    public static HeroController current;

    Rigidbody2D myBody = null;

    public int MaxHealth = 3;
    public int health = 3;
    bool collidedBomb = false;

    public float reload_Time;
    float last_bullet;
    

    public GameObject prefabBullet;

    void Awake()
    {
        current = this;
    }

	// Use this for initialization
	void Start () {
        myBody = this.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}

    public void removeHealth()
    {
        this.health--;
        this.onHealthChange();
        LevelController.current.removeLife();
        Debug.Log(health);
    }

    void onHealthChange()
    {
        if (this.health == 0)
        {
            //GameOver
            //SceneManager.LoadScene("MainMenu");
            LevelController.current.onExitClick();
        }
    }

    public void collideBomb()
    {
        collidedBomb = true;
        this.removeHealth();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    

    void FixedUpdate()
    {
        float value = Input.GetAxis("Horizontal");
        if (Mathf.Abs(value) > 0)
        {
            
                Vector2 vel = myBody.velocity;
                vel.x = value * speed;
                myBody.velocity = vel;
            
        }
        else
        {
            Vector2 vel = myBody.velocity;
            vel.x = 0;
            myBody.velocity = vel; 
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (reloadTime())
            {
                launchBullet();
            }
        }
        
    }

    bool reloadTime()
    {
        return Time.time - last_bullet > reload_Time;
    }

    void launchBullet()
    {
        GameObject obj = GameObject.Instantiate(this.prefabBullet);
        obj.transform.position = this.transform.position;
        
        Vector3 tmp = new Vector3(0, 0.5f, 0);
        obj.transform.position += tmp;
        Bullet bullet = obj.GetComponent<Bullet>();
        bullet.launch();
        last_bullet = Time.time;
    }


}
