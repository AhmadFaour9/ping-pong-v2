using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_manager : MonoBehaviour
{
    public static score_manager instance;
    public TextMeshProUGUI scoreText;
    int score = 0;
    
    private void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text =  score.ToString();
    }
    
    public void addpoint()
    {
        score += 1;
        scoreText.text =  score.ToString();
    }
    public int getscore(){return score;}
    void Update()
    {
        
    }
}