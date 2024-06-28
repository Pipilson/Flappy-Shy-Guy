using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.transform.position.x, 0, -10), Time.deltaTime);
    }
}