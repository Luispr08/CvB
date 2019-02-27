using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Losingscreen : MonoBehaviour
{
  
    public GameObject Lostscreen;
    // Update is called once per frame
    void Update()
    {
        if (LivesScript.lives == 0)
        {
            LostGame();
        }
        else
        {
            Playing();
        }
    }

    public void WatchVideo()
    {
        //Watch video was clicked I have to display a video resume the game and add a life.
        //I have to call the function that destroys all the objects in the screen after this so that the current cubes get destroyed and the user starts in the same wave with new cubes!
        
        Lostscreen.SetActive(false);
        Time.timeScale = 1f;
        LivesScript.lives = 1; //We grant the user a live for watching a video. 
    }

    public void MainMenu()
    {
        //Main menu was clicked I have to send the user to the main menu
        Lostscreen.SetActive(false);
        
        SceneManager.LoadScene(0);
        
    }
    public void PlayAgain()
    {
        //Play again was clicked we have to restart the game completely.
        
        Lostscreen.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);// Loads scene of the game
    }

    public void LostGame()
    {
        Lostscreen.SetActive(true);
        Time.timeScale = 0f;
        Tap.Destro();//Destroys every object in the scene
        Tap.CubeNumberTracker = 0; //Reset cube tracker for multiplier
        MultiplierScript.multi = 0;//Reset multiplier
        UltimateCubeSpawner.SpawnCTRL = true; //Tells the cubes to start spawning again.
    }
    public void Playing()
    {
        Lostscreen.SetActive(false);
        Time.timeScale = 1f;

       
    }
}
