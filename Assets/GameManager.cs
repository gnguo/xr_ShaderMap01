using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    public static GameManager instance;    public Animator camAnim;

    public GameObject titleCam;
    public GameObject gameCam;    public AudioClip bgm;

    public GameObject player;    public bool isCamShake = false;    public bool isShakeOff;    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()    {        SoundManager.instance.SoundPlayShot("bgm", bgm);    }
    private void Update()    {        StartCoroutine(ShowGameCam());    }    public void CamShake()    {        camAnim.SetTrigger("Shake");        Debug.Log("h9");    }
    IEnumerator ShowGameCam()    {        yield return new WaitForSeconds(10.7f);        titleCam.SetActive(false);        gameCam.SetActive(true);        player.SetActive(true);    }}
