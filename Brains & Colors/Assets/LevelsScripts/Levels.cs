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
    public static void level1()
    {
        //Level 1 is the beginning of the game.
        if (ScoreScript.score >=0 && ScoreScript.score <= 500)
        {
            UltimateCubeSpawner.LVL = 3; //We spawn 3 cubes.
            
        }
        else if (ScoreScript.score >= 500 && ScoreScript.score < 1000)//If the player is between 500 & 1000
        {
            //Increase the speed of the cubes by .5 .
            MoveObject.speed = -2.5f; //QUESTION: WILL THE SPEED STAY THE SAME? YES IT DOES STAY THE SAME
        }
        else if (ScoreScript.score >= 1000 && ScoreScript.score < 5000)
        {
            //Introduce 4th cube
            UltimateCubeSpawner.LVL = 4;//4 cubes spawn instead of 3
        }
    }
    public void level2()
    {

    }
    public void level3()
    {

    }
    public void level4()
    {

    }
    public void level5()
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
