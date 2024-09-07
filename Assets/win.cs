using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class win : MonoBehaviour
{ 
    public TextMeshProUGUI scoreText;
    public static win instance;
    string score="";
    string score1="";

    // Start is called before the first frame update
     private void Awake()
    {
        instance = this;
    }
    void Start()
    {       
        // تعيين المكون المناسب لـ scoreText
        scoreText = GetComponent<TextMeshProUGUI>();
        // تحديث قيمة النص في scoreText
        scoreText.text =  score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         score = File.ReadAllText("fullscore.txt");
      
         score1 = File.ReadAllText("fullscore 1.txt");
            Debug.Log(score);
         Debug.Log(score1);
         if(int.Parse(score)>int.Parse(score1)){
            scoreText.text =  "Player1";
         }
      
            if(int.Parse(score)<int.Parse(score1))
         {scoreText.text =  "Player2";}
            
         
            if(int.Parse(score)==int.Parse(score1)){scoreText.text =  "draw up";}
            
         
    }
}