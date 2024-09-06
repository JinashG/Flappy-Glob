using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logicscript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public Text highscore;
   void Start()
   {
     highscore.text=PlayerPrefs.GetInt("highscore",0).ToString();
   }
   public GameObject gameOverScreen;
   [ContextMenu("Increase Score")]
   public void addScore(int ScoreToadd)
   {
        playerScore = playerScore +ScoreToadd;
        scoreText.text = playerScore.ToString();
   }
   public void restartGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void gameOver()
   {
     if(playerScore>PlayerPrefs.GetInt("highscore",0))
        {
          PlayerPrefs.SetInt("highscore",playerScore);
          highscore.text=PlayerPrefs.GetInt("highscore",0).ToString();

        }  
        gameOverScreen.SetActive(true);
   } 
   public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
