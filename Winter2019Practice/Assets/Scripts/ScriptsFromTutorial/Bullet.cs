using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Initial Script Based on Tutorial
    public float speed = 15f;
    public Transform target;
    void Start()
    {
        
    }
    
    void Update()
    {
        Vector3 direction = target.position - this.transform.localPosition;
        float distThisFrame = speed * Time.deltaTime;

        if (direction.magnitude <= distThisFrame)
        {
            DoBulletHit();
        }
        else
        {
            transform.Translate(direction.normalized * distThisFrame, Space.World );
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime*5);
        }
    }

    private void DoBulletHit()
    {
        Destroy(gameObject);
    }
}
