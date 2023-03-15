using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float size;
    [SerializeField] private Transform target;

    private Vector3 offset;

    private void Start()
    {
        offset = target.position - transform.position;
    }

    private void Update()
    {
        var t = Time.time * speed;
        var angle = (Mathf.Sin(Time.time * speed) * size) - size / 2.0f;

        Vector3 newOffset = new Vector3(Mathf.Cos(angle) * offset.z, -offset.y, Mathf.Sin(angle) * offset.z);
        transform.position = target.position + newOffset;

        transform.LookAt(target, Vector3.up);
    }
}
