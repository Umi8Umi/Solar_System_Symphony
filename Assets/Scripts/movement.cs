using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 startPosotion;
    private float frequency = 5f;
    private float magnitude = 5f;
    private float offset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosotion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPosotion + transform.up * Mathf.Sin(Time.time * frequency + offset) * magnitude;
    }
}
