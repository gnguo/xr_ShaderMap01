using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotationSpeed = 5.0f;
    public Camera fallowCam;
    public AudioClip audioFootStep;
    public GameObject particle;

    public GameManager shake;
    Rigidbody rigid;
    Animator anim;
    Vector3 movement;

    bool fDown;
    float h;
    float v;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        // 중력해제
        //rigid.useGravity = false;
    }

    void Update()
    {
        Move();
        Turn();
        GetInput();
    }

    void GetInput()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        fDown = Input.GetButton("Fire1");
    }

    private void Move()
    {
        movement = new Vector3(h, 0, v).normalized;
        if (movement != Vector3.zero)
        {

            anim.SetBool("IsRun", true);
        else
            anim.SetBool("IsRun", false);

    }
    private void Turn()
    {
        transform.LookAt(transform.position + movement);

        if (fDown)
        {
            Ray ray = fallowCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit, 100))
            {
                Vector3 nextVec = raycastHit.point - transform.position;
                transform.LookAt(transform.position + nextVec);
            }

        }
    }

        yield return new WaitForSeconds(1.8f);

        particle.SetActive(false);