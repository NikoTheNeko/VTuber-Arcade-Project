using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePieceCatcher : MonoBehaviour{

    #region Public Variables
    public NekoTheWolfCabinet ArcadeCabinet;
    #endregion

    #region Private Variables
    #endregion

    private void OnTriggerEnter(Collider other) {
        Debug.Log("AHHHH HELP SOMETHING IS ENTERING ME");
        //If the game object is a game piece, add score
        if(other.gameObject.CompareTag("Game Piece")){
            ArcadeCabinet.AddScore(10);
            DestroyObject(other.gameObject);
        }
    }
}
