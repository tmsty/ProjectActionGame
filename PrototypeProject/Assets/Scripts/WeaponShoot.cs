using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro.Examples;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WeaponShoot : MonoBehaviour
{
    public float damage = 30f;
    public float range = 15f;
    public float fireRate = 1f;
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
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
