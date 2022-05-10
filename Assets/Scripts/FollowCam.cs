using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{    public GameObject player;
    private Vector3 offset;
    PlayerController playerMove;

    // Start is called before the first frame update
    private void Awake()    {        playerMove = GetComponent<PlayerController>();                              }
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;    }
}