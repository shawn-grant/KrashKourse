using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DriveableCar : MonoBehaviour {

	VehicleInput inputActions;
	WheelCollider[] wheels;
	VolumeProfile postProcessing;
	Rigidbody rb;
	AudioSource audioSource;
	//HUD
	TextMeshProUGUI currentSpeedText;
	Slider speedometer;
	TextMeshProUGUI gearText;
	Slider gasMeter;

	[Header("Drive")]
	public bool LargeWheels;
	public bool fourWheelDrive = false;
	public GameObject wheelGraphic;

	public float maxAngle = 45;
	public float maxTorque = 2000;
	public float brakeTorque = 8000;
	public float maxSpeed = 200;

	[Header("Collisions")]
	public AudioClip[] highSpeedCrash;
	public AudioClip[] lowSpeedCrash;
	public float crashVelocityLow = 25f;

	float torque, angle = 0;
	float speed = 0;
	bool grounded;
	bool braking;
	[HideInInspector]
	public bool boosting;
	[HideInInspector]
	public bool skidding;

	private void Awake()
	{
		inputActions = new VehicleInput();
		inputActions.Enable();
		inputActions.Move.Brake.started += ctx => braking = true;
		inputActions.Move.Brake.canceled += ctx => braking = false;
		inputActions.Move.Boost.started += ctx => boosting = true;
		inputActions.Move.Boost.canceled += ctx => boosting = false;

		currentSpeedText = GameObject.Find("SpeedTxt").GetComponent<TextMeshProUGUI>();
		speedometer = GameObject.Find("Speedometer").GetComponent<Slider>();
		gearText = GameObject.Find("GearTxt").GetComponent<TextMeshProUGUI>();
		gasMeter = GameObject.Find("GasMeter").GetComponent<Slider>();
		rb = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();

		postProcessing = GameObject.Find("PostProcessor").GetComponent<Volume>().profile;
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

		speedometer.maxValue = maxSpeed;
	}

	public void Update()
	{
		//steer values
		torque = maxTorque * inputActions.Move.Drive.ReadValue<float>();
		angle = maxAngle * inputActions.Move.Steering.ReadValue<float>();

		if (boosting) {
			postProcessing.components[5].active = true;
			postProcessing.components[7].active = true;
			Boost();
		}
		else
		{
			postProcessing.components[5].active = false;
			postProcessing.components[7].active = false;
		}

		//wheel controls
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
				wheel.motorTorque = torque;
			}

			if (wheel.transform.localPosition.z > 0)
			{//front wheels
				wheel.steerAngle = angle;
				//wheel.motorTorque = torque;
			}
			else
			{
				//back wheels
				if(fourWheelDrive)
					wheel.steerAngle = -angle;
			}
		}
	}

	private void FixedUpdate()
	{
		///LIMIT VELOCITY
		rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
	}

	private void LateUpdate()
	{
		Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit hit;
		grounded = (Physics.Raycast(ray, out hit, 3f)) ? true : false;

		///SPEED DISPLAY
		speed = Mathf.Round(rb.velocity.magnitude * 3.6f);
		speedometer.value = speed;
		currentSpeedText.text = speed + "\nkm/h";

		///GAS METER DISPLAY
		float fwd = inputActions.Move.Drive.ReadValue<float>();
		gasMeter.value = fwd;

		///DRIVE GEAR DISPLAY
		if (fwd == 0)
			gearText.text = "N";
		else if (fwd > 0)
			gearText.text = "D";
		else
			gearText.text = "R";

		foreach (WheelCollider wheel in wheels)
		{
			///SKIDDING
			WheelHit wheelHit;
			wheel.GetGroundHit(out wheelHit);
			skidding = (Mathf.Abs(wheelHit.sidewaysSlip) >= 0.5f)? true: false;

			///WHEEL VISUALS
			Quaternion q;
			Vector3 p;
			wheel.GetWorldPose(out p, out q);
			wheel.transform.GetChild(0).position = p; //only child of the wheelcollider is the wheel shape
			wheel.transform.GetChild(0).rotation = q;
		}
	}

	public void Boost()
	{
		rb.AddRelativeForce (new Vector3(0, 0, 200), ForceMode.Impulse);
		//instantiate boost effect
	}

	private void OnCollisionEnter(Collision collision)
	{
		//low vel crash
		if (collision.relativeVelocity.magnitude > 5 && collision.relativeVelocity.magnitude < crashVelocityLow) //20
		{
			audioSource.PlayOneShot(lowSpeedCrash[Random.Range(0, lowSpeedCrash.Length)]);
		}
		else if (collision.relativeVelocity.magnitude >= crashVelocityLow) //high vel crash
		{
			audioSource.PlayOneShot(highSpeedCrash[Random.Range(0, highSpeedCrash.Length)]);
		}
		
	}

}
