using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float senstivity;
    public Transform playcam;
    float x, y, rot;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");     
        y = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * x*senstivity);
        rot -= y * senstivity;
        rot = Mathf.Clamp(rot, -90f, 90f);
        playcam.localRotation = Quaternion.Euler(rot, 0f, 0f);
    }
}
