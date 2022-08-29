using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
    private int initialScore;

    void Start(){
       resetScore();
    }

    public void resetScore(){
        initialScore = 0;
        scoreText.text = initialScore.ToString();
    }

    public void updateScore(){
        initialScore += 1;
        scoreText.text = (initialScore).ToString();
    }
}
