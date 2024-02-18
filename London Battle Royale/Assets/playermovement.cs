using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float MoveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horInput = horInput.GetAxisRaw("Horizontal") * MoveSpeed;
        float verInput = horInput.GetAxisRaw("Vertical") * MoveSpeed;

        rb.velocity = new Vector3(horInput, 0, verInput);
    }
}
