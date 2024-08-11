using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyMenuEffect : MonoBehaviour
{
    public float offsetMutiplier = 1f;
    public float smoothTime = 0.3f;
    private Vector2 startPosition;
    private Vector3 velocity;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector2 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector3.SmoothDamp(transform.position, startPosition + (offset * offsetMutiplier), ref velocity, smoothTime);
    }
}
