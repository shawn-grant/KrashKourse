using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEngineSounds : MonoBehaviour
{
    
    public AudioSource engineIdle;
    public AudioSource accelerate;
    public AudioSource deccelerate;
    public AudioSource skidding;
    public AudioSource boosting;

    VehicleInput inputs;
    DriveableCar player;

    private void Awake()
    {
        inputs = new VehicleInput();
        inputs.Enable();
        player = GetComponentInParent<DriveableCar>();
    }

    private void OnDisable()
    {
        inputs.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float acceleration = inputs.Move.Drive.ReadValue<float>();
        //inputActions.Move.Steering.ReadValue<float>();

        accelerate.volume = Mathf.Lerp(accelerate.volume, acceleration, 0.05f);

        skidding.volume = (player.skidding)? 1: 0;
        boosting.volume = (player.boosting) ? Mathf.Lerp(boosting.volume, 1, 0.05f) : Mathf.Lerp(boosting.volume, 0, 0.05f);
    }
}
