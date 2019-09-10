using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour
{
    private void FixedUpdate()
    {
        ObjectQueue.Instance.SpawnFromPool("SphereBullet", transform.position, Quaternion.identity);
    }
}
