using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAttack : MonoBehaviour
{
    private float speedAttack = 28f;
    private Rigidbody shipRB;
    private GameObject Spaceship;
    [SerializeField]
    private GameObject particleSystemFire;
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip audioClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        particleSystemFire.SetActive(false);
        shipRB = GetComponent<Rigidbody>();
        Spaceship = GameObject.Find("Spaceship");
    }

    void FixedUpdate()
    {
        shipRB.AddForce((Spaceship.transform.position - transform.position).normalized * speedAttack * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Boom"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ship"))
        {
            particleSystemFire.SetActive(true);
            audioSource.PlayOneShot(audioClip, 0.5f);
        } 
    }
}
