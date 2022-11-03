using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float moveSpeed = 80.0f;
    public float rotationSpeed = 200.0f;
    private Animator player;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * moveSpeed);

        player.SetFloat("VelX", x);
        player.SetFloat("VelY", y);
    }
}
