using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public GameObject spawnPoint;
    public Rigidbody projectile1;
    public AudioSource shot;
    public GameObject projectilePrefab;
    public float ShotSpeed;
    public float timer;
    public float nextFire = -1.0f;



    // Use this for initialization
    void Start()
    {
        nextFire = Time.time;
    }
    // Update is called once per frame
    void Update()
    {

        if (Time.time >= nextFire)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                nextFire = nextFire + 1;
                Rigidbody hitPlayer;
                hitPlayer = Instantiate(projectile1, transform.position, transform.rotation) as Rigidbody;
                hitPlayer.velocity = transform.TransformDirection(Vector3.forward * ShotSpeed);
                // AudioSource audio = GetComponent<AudioSource>();
                //  audio.Play();
            }
        }



        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Rigidbody clone;
                clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(Vector3.forward * ShotSpeed);
                //            Physics.IgnoreCollision ( projectilePrefab.collider, transform.root.collider );


            }
        }

    }
}