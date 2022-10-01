using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAndShoot : MonoBehaviour
{
    public Camera mainCamera;
    private Vector3 mousePos;
    public GameObject crosshairs;
    public GameObject player;
    public float force;
    public GameObject bulletPrefab;
    public Transform firePoint;
    private Vector3 aim;
    public float cooldownTime = 1f;
    public bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            if (canShoot)
            {
                StartCoroutine(ShootDelay());
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        crosshairs.transform.position = new Vector2(mousePos.x, mousePos.y);

        Vector3 rotation = mousePos - transform.position;
        float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
    }

    public IEnumerator ShootDelay()
    {
        Shoot();
        canShoot = false;
        yield return new WaitForSeconds(cooldownTime);
        canShoot = true;
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, target.rotation);
    }
}
