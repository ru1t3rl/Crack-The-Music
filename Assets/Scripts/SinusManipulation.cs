using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusManipulation : MonoBehaviour
{
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float frequentie = 0.1f;


    public bool fixX = false;
    public bool fixY = false;
    public bool fixZ = false;

    public bool position = true;
    public bool scale = false;

    private float angle = 0.0f;
    private Vector3 localScale = Vector3.zero;
    private Vector3 localPosition = Vector3.zero;
    [SerializeField] private Vector3 center = Vector3.zero;

    private void Start()
    {
        localPosition = transform.position;
        localScale = transform.localScale;
    }

    void Update()
    {
        angle += frequentie;

        if (!fixX)
        {
            if (scale)
                localScale.x = (amplitude * Mathf.Sin(angle) + center.x) * Time.deltaTime;

            if (position)
                localPosition.x += (amplitude * Mathf.Sin(angle) + center.x) * Time.deltaTime;
        }
        if (!fixY)
        {
            if (scale)
                localScale.y = (amplitude * Mathf.Sin(angle) + center.y) * Time.deltaTime;

            if (position)
                localPosition.y += (amplitude * Mathf.Sin(angle) + center.y) * Time.deltaTime;
        }
        if (!fixZ)
        {
            if (scale)
                localScale.z = (amplitude * Mathf.Sin(angle) + center.z) * Time.deltaTime;

            if (position)
                localPosition.z += (amplitude * Mathf.Sin(angle) + center.z) * Time.deltaTime;
        }

        if (scale)
            transform.localScale = localScale;

        if (position)
            transform.position = localPosition;
    }
}
