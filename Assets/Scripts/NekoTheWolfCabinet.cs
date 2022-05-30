using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NekoTheWolfCabinet : MonoBehaviour{
 
    #region Public Variables
    //Holds the Score for the game
    public int Score;

    //Holds the TextScore Display
    public Text ScoreDisplay;

    //Holds the triggers for the games
    public GameObject[] ScoreTriggers;

    public Game_Piece_Spawner PieceSpawner;
    #endregion

    #region Private Variables



    #endregion

    // Start is called before the first frame update
    private void Start() {
        //Updates the Score Display
        ScoreDisplay.text = "Score\n" + Score.ToString() + "\nBalls Left\n" + PieceSpawner.GetAmountLeft();
    }

    #region Score Triggers

    private void CatchGamePiece(){

    }

    #endregion

    #region Public Functions (Score Management)

    //Call this to add to the score
    public void AddScore(int AmountToAdd){
        //Adds score to the score
        Score += AmountToAdd;

        //Updates the Text
        UpdateText();
    }

    //Updates the text
    public void UpdateText(){
        //Updates the Score Display
        ScoreDisplay.text = "Score\n" + Score.ToString() + "\nBalls Left\n" + PieceSpawner.GetAmountLeft();
    }

    #endregion
}
