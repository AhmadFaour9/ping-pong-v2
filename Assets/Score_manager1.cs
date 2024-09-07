using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_manager1 : MonoBehaviour
{
    public static Score_manager1 instance1;
    public TextMeshProUGUI scoreText1;
    int score1 = 0;
    
    private void Awake()
    {
        instance1 = this;
    }
    
    void Start()
    {
        scoreText1 = GetComponent<TextMeshProUGUI>();
        scoreText1.text =  score1.ToString();
    }
        public int getscore(){return score1;}

    public void addpoint()
    {
        score1 += 1;
        scoreText1.text =  score1.ToString();
    }
    
    void Update()
    {
        
    }
}