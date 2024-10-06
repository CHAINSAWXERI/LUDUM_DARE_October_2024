using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TurretShootZone : MonoBehaviour
{
    [SerializeField] private TurretAiming turret;
    [SerializeField] private TurretShooting turretShooting;
    [SerializeField] private LayerMask TriggerLayer;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Find");

        if (((1 << other.gameObject.layer) & TriggerLayer) != 0)
        {
            Debug.Log("Find Find");
            turret.SetTarget(other.transform);
            turretShooting.Shoot();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (((1 << other.gameObject.layer) & TriggerLayer) != 0)
        {
            turret.SetTarget(null);
        }
    }
}
