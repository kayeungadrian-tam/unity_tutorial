using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;


    [ContextMenu("Score")]
    public void addScore(int scroeToAdd){
        playerScore += scroeToAdd;
        scoreText.text = playerScore.ToString(); 
    }
    
    
    public void restartGame()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void gameOver()
    {
    	gameOverScreen.SetActive(true);
    }


}
