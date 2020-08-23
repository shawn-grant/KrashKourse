using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEngineSounds : MonoBehaviour
{
    
    public AudioSource engineIdle;
    public AudioSource accelerate;
    public AudioSource deccelerate;
    public AudioSource skiding;

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

        if (player.speed > 50 && player.braking)
            skiding.volume = 1;
        else skiding.volume = 0;

            
    }
}
