using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 _direction = Vector3.zero;

    private void Update()
    {
        Move();
    }

    public void ChangeDirection(Vector3 newDirection)
    {
        _direction = newDirection;
    }

    private void Move()
    {
        transform.Translate(_direction * Time.deltaTime);
    }
}
