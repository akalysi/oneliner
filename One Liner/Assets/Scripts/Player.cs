using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private float speed = 0f;
    private float speedRegular = 2.5f;
    private float speedSprint = 4.5f;

    private Rigidbody2D rb;
    private Camera mcam;

    public TMP_Text Text1;
    public TMP_Text Text2;

    private int level = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mcam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) speed = speedSprint;
        else speed = speedRegular;

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Win"))
        {
            level++;
            transform.position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
            mcam.transform.position = new Vector3(mcam.transform.position.x + 18, mcam.transform.position.y, mcam.transform.position.z);
            Text1.text = "";
            Text2.text = "";
        }
    }
}
