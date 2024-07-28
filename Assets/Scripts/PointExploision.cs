using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PointExploision : MonoBehaviour
{
    [SerializeField]
    private int poolCount = 6;
    [SerializeField]
    private bool autoExpand = true;
    [SerializeField]
    public BoomController pointBoom;
    [SerializeField]
    public Camera camera;

    private AudioSource audioSource;
    [SerializeField]
    private AudioClip boomPlayer;

    private ObjectPoolBoom<BoomController> boom;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.boom = new ObjectPoolBoom<BoomController>(this.pointBoom, this.poolCount, this.transform);
        this.boom.autoExpand = this.autoExpand;
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.CreateBoom();
            audioSource.PlayOneShot(boomPlayer, 1.0f);
        }
    }

    private void CreateBoom()
    {
        var boomPosition = camera.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward;
        var boom = this.boom.GetFreeElement();
        boom.transform.position = boomPosition;
    }
}
