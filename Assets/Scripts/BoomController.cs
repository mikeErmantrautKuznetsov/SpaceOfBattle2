using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{
    private void OnEnable()
    {
        this.StartCoroutine("DeletBoom"); 
    }

    private void OnDisable()
    {
        this.StopCoroutine("DeletBoom");
    }


    private IEnumerator DeletBoom()
    {
        yield return new WaitForSeconds(1);

        Deactive();
    }

    private void Deactive()
    {
        this.gameObject.SetActive(false);
    }
}
