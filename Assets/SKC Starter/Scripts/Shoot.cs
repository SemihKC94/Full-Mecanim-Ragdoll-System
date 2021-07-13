/*//////////////////////////////////////////////////////////////////////////////////////////
//      █─▄▄▄▄█▄─█─▄█─▄▄▄─█                                                               //
//      █▄▄▄▄─██─▄▀██─███▀█             Scripts created by Semih Kubilay Çetin            //
//      ▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀                                                               //
//////////////////////////////////////////////////////////////////////////////////////////*/
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public KeyCode shootKey = KeyCode.Mouse0;
    public Rigidbody projectile;
    public Transform firePoint;
    public float speed;
    public float mass;

    private void Update()
    {
        if(Input.GetKeyDown(shootKey))
        {
            SpawnProjectile();
        }
    }

    private void SpawnProjectile()
    {
        Rigidbody tempProjectile = Instantiate(projectile, firePoint.position, firePoint.rotation) as Rigidbody;
        tempProjectile.mass = mass;
        tempProjectile.velocity = transform.forward * speed * Time.deltaTime;
        Destroy(tempProjectile, 3f);

    }
}

/* Tip    #if UNITY_EDITOR
          Debug.Log("Unity Editor");
          #endif                          Tip End */