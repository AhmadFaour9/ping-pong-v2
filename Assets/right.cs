using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class right : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Ball b = other.collider.GetComponent<Ball>();
                        score_manager.instance.addpoint();
        if(b!=null && score_manager.instance.scoreText.text=="3"){
               string score = File.ReadAllText("fullscore.txt");
              File.WriteAllText("fullscore.txt", (int.Parse(score)+1).ToString());

            if(SceneManager.GetActiveScene().buildIndex==3){
                                 File.WriteAllText("fullscore.txt", (int.Parse(score)+2).ToString());

            }
            if(SceneManager.GetActiveScene().buildIndex==4){
            File.WriteAllText("fullscore.txt", (int.Parse(score)+3).ToString());


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
