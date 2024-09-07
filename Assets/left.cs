using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class left : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Ball b = other.collider.GetComponent<Ball>();
                        Score_manager1.instance1.addpoint();

        if(b!=null && Score_manager1.instance1.scoreText1.text=="3"){
               string score = File.ReadAllText("fullscore 1.txt");
                            File.WriteAllText("fullscore 1.txt",(int.Parse(score)+1).ToString());

  if(SceneManager.GetActiveScene().buildIndex==3){
             File.WriteAllText("fullscore 1.txt",(int.Parse(score)+2).ToString());

            }
            if(SceneManager.GetActiveScene().buildIndex==4){
         File.WriteAllText("fullscore 1.txt",(int.Parse(score)+3).ToString());


            }

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Destroy(b.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
