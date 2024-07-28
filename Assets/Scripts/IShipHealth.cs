using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IShipHealth : MonoBehaviour
{
    private float Health = 10;
    [SerializeField]
    private GameObject LoseMenu;

    private void Start()
    {
        LoseMenu.SetActive(false);
        StartCoroutine(cheackHealth());
    }

    IEnumerator cheackHealth()
    {
        yield return new WaitForSeconds(0.5f);
        if (Health <= 0 )
        {
            Time.timeScale = 0;
        }
        StartCoroutine(cheackHealth());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Health = Health - 10;
            LoseMenu.SetActive(true);
        }
    }
}
