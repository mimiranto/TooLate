using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EcolierMouv : MonoBehaviour
{
    public Rigidbody rigi;
    private Vector3 avance;
    private float timer;
    public Surface sol;
    public AnimationManager anim;
    public float jumptimer;
    public float Raycastoff;
    public float Raycastdistance;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        avance = Vector3.right * horizontal + Vector3.forward * vertical;
        avance = avance.normalized * sol.vitesseMatt;

        if (Input.GetButtonDown("Jump") && IsOnTheGround())
        {
            anim.saut();
            rigi.AddForce(Vector3.up * sol.jumpforce);
            timer = jumptimer;
            anim.saut();
        }
        timer -= Time.deltaTime;
    }
    public void FixedUpdate()
    {
        if (IsOnTheGround())
        {
            rigi.velocity = avance;
            anim.avance(rigi.velocity.magnitude);
        }
    }
    public bool IsOnTheGround()
    {
        return (Physics.Raycast(transform.position + Vector3.up * Raycastoff, Vector3.down,Raycastdistance) && timer < 0);
    }
}
