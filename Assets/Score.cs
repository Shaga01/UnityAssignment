using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score =0;
    // Start is called before the first frame update
    public static Score Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();

    }

 
}
