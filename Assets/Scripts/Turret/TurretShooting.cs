using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float shootInterval;

    private float lastShootTime;

    public void Shoot()
    {
        if (Time.time >= lastShootTime + shootInterval)
        {
            //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Debug.Log("POW");
            lastShootTime = Time.time;
        }
    }
}
