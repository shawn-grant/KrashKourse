using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

/*
 * GameObject Structure:
 * Object
 *   |___ Arm
 *        |___ Spawn points
 *        |___ Other Parts
 */

public class PrimaryWeapon : MonoBehaviour
{
    VehicleInput inputActions;
    AudioSource audioSource;
    GameObject CM_Cam;
    Rumbler rumbler;
    float nextTimeToFire = 0;
    bool aiming = false;
    bool shooting;

    public enum WeaponType { 
        RayCast, Particle
    }

    [Header("MISC")]
    public Transform rotator;
    public Transform arm;
    public Transform[] spawns;

    public GameObject muzzleFlash;
    public AudioClip fireSound;
    public AudioClip reloadSound;
    public AudioClip emptySound;

    public WeaponType weaponType;

    [Header("GUN FIRE SETTINGS")]
    public float fireRate = 15;

    void Awake()
    {
        inputActions = new VehicleInput();
        inputActions.Enable();

        inputActions.Attack.ToggleAim.performed += ctx => aiming = !aiming;
        inputActions.Attack.ShootPrimary.started += ctx => shooting = true;
        inputActions.Attack.ShootPrimary.canceled += ctx => shooting = false;
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        CM_Cam = GameObject.FindGameObjectWithTag("CM Main Camera");
        rumbler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Rumbler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shooting && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            Shoot();
        }

        //aiming the gun
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        Vector3 dir = ray.GetPoint(100) - transform.position;
        Quaternion lookRot = Quaternion.LookRotation(dir);

        transform.localRotation = Quaternion.Euler (0, lookRot.y, 0);
        //arm.localEulerAngles = new Vector3 (-lookRot.eulerAngles.x, 0, 0);

        if (aiming) //fine Aim
        {
            CM_Cam.GetComponent<CinemachineFreeLook>().m_Lens.FieldOfView = 28;
            CM_Cam.GetComponent<CinemachineCameraOffset>().m_Offset = new Vector3(2, 1, 0);
            //crosshair.SetActive(true);
        }
        else
        {
            CM_Cam.GetComponent<CinemachineFreeLook>().m_Lens.FieldOfView = 40;
            CM_Cam.GetComponent<CinemachineCameraOffset>().m_Offset = new Vector3(0, 0, 0); ;
            //crosshair.SetActive(false);
        }
    }

    public void Shoot()
    {
        audioSource.PlayOneShot(fireSound);
        rumbler.RumbleConstant(0f, 0.1f, 0.1f);

        if(weaponType == WeaponType.RayCast)
        {
            RaycastHit hit;

            foreach(Transform spawn in spawns)
            {
                //Instantiate(muzzleFlash, spawn.position, new Quaternion());

                if (Physics.Raycast(spawn.position, spawn.forward, out hit, 100))
                {
                    Debug.Log("Hit Object");
                }
            }
            
        }
    }
}
