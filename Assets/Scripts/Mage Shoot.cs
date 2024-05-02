using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageShoot : MonoBehaviour
{
    public float timer = 5.0f;
    public GameObject magicBullet;
    public float bulletTime;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootBullet();
    }

    void ShootBullet()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(magicBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
    }
}
