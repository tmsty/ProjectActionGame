using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro.Examples;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WeaponShoot : MonoBehaviour
{
    public int playerDamage = 10;
    public float range = 15f;
    public float fireRate = 1f;
    public float EnemyHealthPoint = 20f;
    public Transform bulletSpawn;
    public AudioClip shotSFX;
    public AudioSource _audioSource;
    public ParticleSystem muzzleFlash;

    public Camera MainCamera;
    private float nextFire = 0f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            Shoot();
            nextFire = Time.time + fireRate;
        }
    }
    void Shoot()
    {
        _audioSource.PlayOneShot(shotSFX);
        //Instantiate(muzzleFlash, bulletSpawn.position, bulletSpawn.rotation);
        muzzleFlash.Play();

        RaycastHit hit;

        if (Physics.Raycast(MainCamera.transform.position, MainCamera.transform.forward, out hit, range))
        {
            Debug.Log("Убийство " + hit.collider);
        }

        if (hit.collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(hit.collider.gameObject);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
        //if (collision.gameObject.CompareTag("Enemy"))
        //{
            //Destroy(collision.gameObject);
        //}
    //}
}
