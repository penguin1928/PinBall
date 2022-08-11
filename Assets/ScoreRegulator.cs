using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRegulator : MonoBehaviour
{
    private int score = 0;
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        this.scoreText.GetComponent<Text>().text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 40;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
        }
    }
}
