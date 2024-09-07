using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class MainMenu : MonoBehaviour
{
public void PlayGame(){

        // Open the file in append mode and write the number to it
    File.WriteAllText("fullscore 1.txt", "0");

    File.WriteAllText("fullscore.txt", "0");

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
}
public void QuitGame(){
    Debug.Log("QuitGame");
    Application.Quit();
}
}
