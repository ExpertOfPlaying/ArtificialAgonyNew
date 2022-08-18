using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{

    private float startPosY;
    [SerializeField] float Speed;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        startPosY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // transform.position += new Vector3(0, Speed * Time.deltaTime, 0);
    }


    public void Move(float h, float v)
    {
        float x = h * Time.deltaTime * Speed;
        float y = v * Time.deltaTime * Speed;
        float z = 0;

        transform.Translate(x, y, z);
        //transform.position += new Vector3(x, y, z);
    }

}
