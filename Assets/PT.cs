using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PT : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public Text highScore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Points")
        {

            AddScore();
           
        }
        if (collision2D.gameObject.tag == "Points2")
        {

            AddScore2();

        }
        if (collision2D.gameObject.tag == "HP")
        {

            AddScore3();

        }
        if (collision2D.gameObject.tag == "BN")
        {

            AddScore();

        }
        void AddScore()
        {
            Score+=50;
            ScoreText.text = Score.ToString();

            if (Score > PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", Score);
                highScore.text = Score.ToString();
            }
        }
        void AddScore2()
        {
            Score +=5;
            ScoreText.text = Score.ToString();
            if (Score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", Score);
                highScore.text = Score.ToString();
            }
        }
        void AddScore3()
        {
            Score += 2;
            ScoreText.text = Score.ToString();
            if (Score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", Score);
                highScore.text = Score.ToString();
            }
        }
    }

 
}