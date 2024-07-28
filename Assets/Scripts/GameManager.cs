using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float range = 30f;
    private int second = 1;

    private void LateUpdate()
    {
        RangeBird();
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    private void RangeBird()
    {
        if (transform.position.x < -range || transform.position.x > range)
        {
            gameObject.SetActive(false);
        }
    }

    public void ReturnGame()
    {
        SceneManager.LoadScene(1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(2);
        Debug.Log(collision.name);
    }
}
