using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot : MonoBehaviour
{
    SpriteRenderer sr;
    Animator anim;

    public float projectileSpeed;
    public Transform spawnPointLeft;
    public Transform spawnPointRight;
    public Projectile projectilePrefab;

    public void Fire()
    {
        if (!sr.flipX)
        {
            projectilePrefab curProjectile = Instantiate(projectilePrefab,
                spawnPointRight.position, SpawnPointRight.rotation);
            curProjectile.speed = projectileSpeed;
        }
        else
        {
            projectilePrefab curProjectile = Instantiate(projectilePrefab,
                spawnPointLeft.position, spawnPointLeft.rotation);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
