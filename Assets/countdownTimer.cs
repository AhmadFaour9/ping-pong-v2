using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 using UnityEngine.SceneManagement;
using System.IO;
public class countdownTimer : MonoBehaviour
{float currentTime=0f;
float startigTime=10f;
    public static countdownTimer instance2;

public TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime=startigTime;
               

    }
    private void Awake()
    {
        instance2 = this;
    }
    public float timer(){
        return currentTime;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime-=1*Time.deltaTime;
       countdownText.text=currentTime.ToString("0");
       if(currentTime<=0){
        currentTime=0;}
        
        int s=int.Parse(score_manager.instance.scoreText.text);
       int s1= int.Parse(Score_manager1.instance1.scoreText1.text);
        
        if(currentTime<=0 && s>s1){
            string score = File.ReadAllText("fullscore.txt");
                         File.WriteAllText("fullscore.txt",(int.Parse(score)+1).ToString());

            if(SceneManager.GetActiveScene().buildIndex==3){
                                 File.WriteAllText("fullscore.txt", (int.Parse(score)+2).ToString());

            }
            if(SceneManager.GetActiveScene().buildIndex==4){
            File.WriteAllText("fullscore.txt", (int.Parse(score)+3).ToString());


            }

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
             else
                if(currentTime<=0 && s1>s){
              string score1 = File.ReadAllText("fullscore 1.txt");
             File.WriteAllText("fullscore 1.txt",(int.Parse(score1)+1).ToString());
            if(SceneManager.GetActiveScene().buildIndex==3){
             File.WriteAllText("fullscore 1.txt",(int.Parse(score1)+2).ToString());

            }
            if(SceneManager.GetActiveScene().buildIndex==4){
         File.WriteAllText("fullscore 1.txt",(int.Parse(score1)+3).ToString());


            }

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            
            else{
                if(currentTime<=0 && s1==s){
            string score = File.ReadAllText("fullscore.txt");
            File.WriteAllText("fullscore.txt",(int.Parse(score)+1).ToString());
            string score1 = File.ReadAllText("fullscore 1.txt");
             File.WriteAllText("fullscore 1.txt",(int.Parse(score1)+1).ToString());
            if(SceneManager.GetActiveScene().buildIndex==3){
             File.WriteAllText("fullscore 1.txt",(int.Parse(score1)+2).ToString());
             File.WriteAllText("fullscore.txt",(int.Parse(score)+2).ToString());

            }
            if(SceneManager.GetActiveScene().buildIndex==4){
         File.WriteAllText("fullscore 1.txt",(int.Parse(score1)+3).ToString());
         File.WriteAllText("fullscore.txt",(int.Parse(score)+3).ToString());


            }

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }}
            }

}
