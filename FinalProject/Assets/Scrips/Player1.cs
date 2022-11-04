using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    private float moveSpeed = 80.0f;
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
        Move();
    }

    void Move(){
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Translate(x, 0, 0 * Time.deltaTime * (moveSpeed + 40.0f));
        transform.Translate(0, 0, y * Time.deltaTime * moveSpeed);

        player.SetFloat("VelX", x);
        player.SetFloat("VelY", y);
    }
}
