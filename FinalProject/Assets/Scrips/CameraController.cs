using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float mouseSensitivity = 80.0f;
    [SerializeField]Transform cameraAnchor = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    public Vector2 MouseControl(){
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        return new Vector2(x,y);
    }

    void MoveCamera(){

        Vector2 input = MouseControl();

        transform.Rotate(Vector3.up * input.x * mouseSensitivity * Time.deltaTime);

        Vector3 angle = cameraAnchor.eulerAngles;
        angle.x += -input.y * mouseSensitivity * Time.deltaTime;

        cameraAnchor.eulerAngles = angle;
    }
}
