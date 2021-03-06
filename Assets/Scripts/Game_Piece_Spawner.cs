using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Piece_Spawner : MonoBehaviour{
    
    #region Public Variables

    [Tooltip("This is the the piece that you plan to spawn")]
    public GameObject GamePieceToSpawn;

    [Tooltip("The Max amount of pieces that a player can use")]
    public int MaxPieces = 50;

    public NekoTheWolfCabinet Cabinet;


    #endregion

    #region Private Variables
    [SerializeField]
    [Tooltip("This is the amount of time you need to wait before you can press for a new ball")]
    private float DelayAmountOfTime = 0.5f;

    //This is the actual timer that will count to zero.
    private float DelayTimer;

    //This prevents the spawner from spawnning if it is ready to spawn
    private bool ActiveCanSpawn = true;

    //
    private int AmountOfPiecesLeft;

    #endregion

    // Start is called before the first frame update
    void Start(){
        //Sets Delay Timer to the Amount of time specified
        DelayTimer = DelayAmountOfTime;

        //The amount of balls left
        AmountOfPiecesLeft = MaxPieces;
    }

    // Update is called once per frame
    void Update(){
        //Presses to spawn the game piece
        if(Input.GetButtonDown("use"))
            SpawnGamePiece();

        //Counts down the timer
        CountDownTimer();

    }

    #region Spawning Functions

    //This function will spawn a game piece.
    //A very simple function, not much happening here.
    private void SpawnGamePiece(){
        //Creates a Quaternion to spawn
        Quaternion SpawnRotation = new Quaternion(0, 0, 0, 0);

        //If you can spawn a piece
        if(ActiveCanSpawn && AmountOfPiecesLeft > 0){
            //Then spawn the piece
            Object.Instantiate(GamePieceToSpawn, transform.position, SpawnRotation);
            //Active will be set to false, so you can no longer spawn until it is reactived
            ActiveCanSpawn = false;
            //Decrements the amount of pieces
            AmountOfPiecesLeft--;
            //Updates the Text
            Cabinet.UpdateText();
        }
    }

    #endregion

    #region Timer Functions

    //CountDownTimer is for the timer so it can actually count down.
    private void CountDownTimer(){
        //Check to see if ActiveCanSpawn is false AND timer is bigger than 0
        if(!ActiveCanSpawn && DelayTimer >= 0){
            //If it is false, start ticking down the timer
            DelayTimer -= Time.deltaTime;
        }

        //If the timer is 0, then reset the states back to default
        //Time = DelayAmountOfTime / ActiveCanSpawn = true
        if(DelayTimer <= 0 && !ActiveCanSpawn){
            DelayTimer = DelayAmountOfTime;
            ActiveCanSpawn = true;
        }

    }

    #endregion

    #region Public Functions

    //Returns the amount of pieces left
    public int GetAmountLeft(){
        return AmountOfPiecesLeft;
    }

    #endregion

}
