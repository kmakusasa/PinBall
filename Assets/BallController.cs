using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour{
    
	private float visiblePosZ = -6.5f;
    
	private GameObject gameoverText;

    private GameObject scoreText;

    private int score = 0;
    
	void Start() {

        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreText");
    }

    void Update() {

        if (this.transform.position.z < this.visiblePosZ) {

            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "LargeStarTag")
        {
            score = score + 30;
        }
        else if (other.gameObject.tag == "SmallStarTag")
        {
            score = score + 10;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score = score + 10;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score = score + 10;
        }
        scoreText.GetComponent<Text>().text = score.ToString();
    }
}