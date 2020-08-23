using UnityEngine;
using TMPro;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

public class DriveableCar : MonoBehaviour {

	VehicleInput inputActions;
	public bool LargeWheels;
	public bool fourWheelDrive = false;
	public GameObject wheelGraphic;

	public float maxAngle = 45;
	public float maxTorque = 2000;
	public float brakeTorque = 8000;

	WheelCollider[] wheels;
	float torque, angle = 0;
	bool grounded;
	[HideInInspector]
	public bool braking;

	//HUD
	TextMeshProUGUI currentSpeedText;
	Slider speedometer;
	TextMeshProUGUI gearText;
	Slider gasMeter;

	[HideInInspector]
	public float speed = 0;
	Rigidbody rb;

	private void Awake()
	{
		inputActions = new VehicleInput();
		inputActions.Enable();
		inputActions.Move.Brake.started += ctx => braking = true;
		inputActions.Move.Brake.canceled += ctx => braking = false;
		currentSpeedText = GameObject.Find("SpeedTxt").GetComponent<TextMeshProUGUI>();
		speedometer = GameObject.Find("Speedometer").GetComponent<Slider>();
		gearText = GameObject.Find("GearTxt").GetComponent<TextMeshProUGUI>();
		gasMeter = GameObject.Find("GasMeter").GetComponent<Slider>();
		rb = GetComponent<Rigidbody>();
	}

	private void OnDisable()
	{
		inputActions.Disable();
	}

	// here we find all the WheelColliders down in the hierarchy
	void Start()
	{
		wheels = transform.GetComponentsInChildren<WheelCollider>();
		foreach (WheelCollider wheel in wheels)
		{
			//wheel.gameObject.GetComponent<Renderer>().enabled = false;
			Transform a = Instantiate(wheelGraphic).transform;
			a.SetParent(wheel.transform);

			if (LargeWheels)
				a.localScale *= 1.5f;
			else
				a.localScale *= 1f;
		}
		
		if(transform.Find("COM"))
			GetComponent<Rigidbody>().centerOfMass = transform.Find("COM").localPosition;
		
	}

	// this is a really simple approach to updating wheels
	// here we simulate a rear wheel drive car and assume that the car is perfectly symmetric at local zero
	// this helps us to figure our which wheels are front ones and which are rear
	public void Update()
	{

		//steer values
		torque = maxTorque * inputActions.Move.Drive.ReadValue<float>();
		angle = maxAngle * inputActions.Move.Steering.ReadValue<float>();

		//wheel movement
		foreach (WheelCollider wheel in wheels) {
			// a simple car where front wheels steer while rear ones drive

			//braking
			if (braking)
			{
				wheel.brakeTorque = brakeTorque;
				//wheel.motorTorque = 0;
			}
			else
			{
				wheel.brakeTorque = 0;
			}

			if (wheel.transform.localPosition.z > 0)
			{//front wheels
				wheel.steerAngle = angle;
				wheel.motorTorque = torque;
			}
			else
			{
				//back wheels
				if(fourWheelDrive)
					wheel.steerAngle = -angle;
			}

			Quaternion q;
			Vector3 p;
			wheel.GetWorldPose(out p, out q);

			// assume that the only child of the wheelcollider is the wheel shape
			wheel.transform.GetChild(0).position = p;
			wheel.transform.GetChild(0).rotation = q;
		}
	}

	private void LateUpdate()
	{
		Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit hit;
		grounded = (Physics.Raycast(ray, out hit, 3f)) ? true : false;

		speed = Mathf.Round(rb.velocity.magnitude * 3.6f);
		speedometer.value = speed;
		currentSpeedText.text = speed + "\nkm/h";

		float fwd = inputActions.Move.Drive.ReadValue<float>();
		gasMeter.value = fwd;

		if (fwd == 0)
			gearText.text = "N";
		else if (fwd > 0)
			gearText.text = "D";
		else
			gearText.text = "R";

		//Skidding
		foreach (WheelCollider wheel in wheels)
		{
			WheelHit wheelHit;
			wheel.GetGroundHit(out wheelHit);

			if (Mathf.Abs(wheelHit.sidewaysSlip) >= 0.6f)
				Debug.Log("skidding");
		}

	}

}
