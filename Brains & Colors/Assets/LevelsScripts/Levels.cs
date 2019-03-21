using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    //Level scripts are controlled by the score of the user. 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //First I want to write down what each level should do to challenge the user. I have to recognize the score and find out what scores fit the level correctly and its challenge.

    /*LEVELS SHOULD AFFECT
     *-Speed of the cubes
     *-Number of cubes of the same colors spawned at once.
     *-Variety of colored cubes (more cubes of different colors, which would be green, and purple added)
     *-Number of cubes spawned at once (Instead of always 5 cubes since the beginning spawn 3 cubes and increase to 5) **This requires more changes in the spawner code**
     *-Rules: Rules tell the player what they have to do for example. Rule will say tap cubes with the color that matches the letter of the identifier. OR tap the letters that are the same color as the identifier. AND SO ON
     * 
     */
    public static void level1() //THIS IS LEVEL 1!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    {
        //I CAN WRITE SOMETHING LIKE WELCOME GET YOU BRAIN READY! ETC

        //Level 1 is the beginning of the game.
        if (ScoreScript.score >= 0 && ScoreScript.score <= 500)
        {
            UltimateCubeSpawner.LVL = 3; //We spawn 3 cubes.
            MoveObject.speed = -2.5f;

        }
        else if (ScoreScript.score >= 500 && ScoreScript.score < 2000)//If the player is between 500 & 1000
        {
            //Increase the speed of the cubes by .5 .
            
            MoveObject.speed = -3f; //QUESTION: WILL THE SPEED STAY THE SAME? YES IT DOES STAY THE SAME
            
            UltimateCubeSpawner.DuplicateCubes = true; //We want to have duplicate cubes here.
            
        }
        else if (ScoreScript.score >= 2000 && ScoreScript.score < 10000)
        {
            //Introduce 4th cube
            UltimateCubeSpawner.LVL = 4;//4 cubes spawn instead of 3
            UltimateCubeSpawner.DuplicateCubes = false; //No more Duplicates
        }
        else if (ScoreScript.score >= 10000 && ScoreScript.score < 20000)
        {
            MoveObject.speed = -6f; //Increase speed a little more.
            UltimateCubeSpawner.DuplicateCubes = true; //We want Duplicates.
        }
        
    }


    public static void level2() //THIS IS LEVEL 2!!!!!!!!!!!!!!
    {
        if (ScoreScript.score >= 20000 && ScoreScript.score < 25000)
        {
            UltimateCubeSpawner.LVL = 5; //Introduce the 5th cube
            UltimateCubeSpawner.DuplicateCubes = false; //No cubes duplicates
            MoveObject.speed = -5f; //Reduce speed by 1
        }
        else if (ScoreScript.score >= 25000 && ScoreScript.score < 35000)
        {
            UltimateCubeSpawner.DuplicateCubes = true; //Allow duplicates
            MoveObject.speed = -6f; //Make them go faster
        }
    }


    public static void level3()
    {
        if (ScoreScript.score >= 35000 && ScoreScript.score < 45000)
        {
            UltimateCubeSpawner.lvlctrl = -1; //Introduce green cube
            UltimateCubeSpawner.DuplicateCubes = false; //No duplicates
        }
        else if (ScoreScript.score >= 45000 && ScoreScript.score < 60000)
        {
            UltimateCubeSpawner.DuplicateCubes = true; //Duplicates
            MoveObject.speed = -6.5f; //Increase speed.
        }
    }

    public static void level4()
    {
        if (ScoreScript.score >= 60000 && ScoreScript.score < 75000)
        {
            UltimateCubeSpawner.lvlctrl = 0; //Introduce purple cube
            UltimateCubeSpawner.DuplicateCubes = false; //No duplicates
            MoveObject.speed = -7.5f;
        }
        else if (ScoreScript.score >= 75000 && ScoreScript.score < 100000)
        {
            UltimateCubeSpawner.DuplicateCubes = true; //Duplicates
            MoveObject.speed = -9f; //Speed
        }
    }
    public static void level5()
    {

    }

    /*
     * IDEAS:
     * Instead of spawning 5 cubes at the beginning spawn 3 and the in a fast fashion increase to 5 cubes at a time.
     */
     /*IMPORTANT NOTES ABOUT THIS SCRIPT
      * global variables (static) and changes that are done through here are permanent and unless they are executed again they wont change.
      * So it is safe to make a change and assume it will stay like that until I decide to change it. For example if I change speed from -2 to -4 the speed will remain -4 Until 
      * the end of the execution of the game.
      */
}
