using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{    [SerializeField] float camForce = 0f;
    public IEnumerator ShakeCoroutine(float duration, float magnitude)    {        Vector3 orginalPos = transform.localPosition;        float elapsed = 0f;        while(elapsed <duration)        {            float x = Random.Range(-1f, 1f) * magnitude;            float y = Random.Range(-1f, 1f) * magnitude;            transform.localPosition = new Vector3(x, y, orginalPos.z);            elapsed += Time.deltaTime;            yield return null;        }        transform.localPosition = orginalPos;    }}//(GameManager.instance.isCamShake && !GameManager.instance.isCamShake)//(!GameManager.instance.isCamShake && GameManager.instance.isCamShake)