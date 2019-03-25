using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    public float speed;
    public GameObject prefabExplossion;
    public Transform mainCameraTransform;
    private void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }

    void Update () {
        transform.Translate(mainCameraTransform.forward * Time.deltaTime * speed);
	}
}
