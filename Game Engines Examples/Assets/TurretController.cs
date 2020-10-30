using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{

    Quaternion start;
    Quaternion end;

    public float rotSpeed = 20.0f;
    public float fireRate = 3;

    public Transform target;
    public Transform spawnPoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {

        Vector3 toTarget = target.transform.position - transform.position;
        start = transform.rotation;
        end = Quaternion.LookRotation(toTarget);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        Rotate();
    }

    void OnTriggerStay()
    {
        Rotate();
        Shoot();
    }

    void Rotate()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, end, rotSpeed * Time.deltaTime);
    }

    void Shoot()
    {
        GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);
        bullet.transform.position = spawnPoint.position;
        bullet.transform.rotation = this.transform.rotation;
    }

    void OnEnable()
    {
        StartCoroutine(ShootingCoroutine());
    }

    bool shooting = false;

    System.Collections.IEnumerator
    ShootingCoroutine()
        {
            while(true)
            {
                Shoot();
                yield return new WaitForSeconds(1.0f / fireRate);
            }
            yield return null;
        }
}
