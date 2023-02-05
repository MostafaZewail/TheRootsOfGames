using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public float speed = 5;
    public Transform point1;
    public Transform point2;

    IEnumerator Start()
    {
        Transform target = point1;
        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, target.position) <= 0)
            {
                target = target == point1 ? point2 : point1;
                yield return new WaitForSeconds(0.5f);
                transform.localRotation *= Quaternion.Euler(0, 180, 0);
            }
            yield return null;
        }
    }
}
