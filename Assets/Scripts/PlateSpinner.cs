using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateSpinner : MonoBehaviour{

    #region Public Variables
    //[Tooltip("The Rigidbody of the plate that is being spinned")]
    //public Rigidbody Plate;

    [Tooltip("The speed at which the plate rotate")]
    [Range(1f, 200.0f)]
    public float SpinSpeed = 5;
    #endregion

    #region Private Variables
    Vector3 SpinDirection;
    #endregion

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        SpinDirection = new Vector3(0, SpinSpeed, 0);

        transform.Rotate(SpinDirection * Time.deltaTime);

    }



}
