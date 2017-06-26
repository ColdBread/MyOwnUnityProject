using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

    public float levelSpeed;
    public int levelReward;

    public static LevelController current;
    void Awake()
    {
        current = this;
    }

	// Use this for initialization
	void Start () {
        
	}

    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void onExitClick()
    {
        //SceneManager.LoadScene("MainMenu");
        showEndPopUp();
    }


	
	// Update is called once per frame
	void Update () {
		
	}

    private int score = 0;

    public void onEnemyDestroy()
    {
        score += levelReward;
        ScoreController.current.updateScore(score);
    }

    public void removeLife()
    {
        LivesController.current.removeLife();
    }

    public LocalStats getStats()
    {
        LocalStats stats = new LocalStats
        {
            score = score
        };
        return stats;
    }

    public GameObject endPopUpPrefab;
    public GameObject popupParent;

    public void showEndPopUp()
    {
        LocalStats stats = this.getStats();
        GameObject parent = UICamera.first.transform.parent.gameObject;
        GameObject ibj = NGUITools.AddChild(parent, endPopUpPrefab);
        EndPopUp popUp = object.getComponent<EndPopUp>();
        stats.save();
        popUp.setStats(stats);
    }
}
