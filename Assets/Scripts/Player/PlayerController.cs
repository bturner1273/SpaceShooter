using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;

    public float speed;
    public GameObject bullet;
    public Transform[] bulletSpawnLocations;
    public KeyCode shoot;

    private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shoot))
        {
            //Instantiate our bullet
            for (int i = 0; i < bulletSpawnLocations.Length; i++)
            {
                Instantiate(bullet, bulletSpawnLocations[i].position, Quaternion.identity);
            }
        }
        direction = Input.GetAxisRaw("Horizontal") * Vector2.right + Input.GetAxisRaw("Vertical") * Vector2.up;
        rb.velocity = direction.normalized * speed * Time.deltaTime;
        anim.SetFloat("vx", rb.velocity.x);
    }
}
