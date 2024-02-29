using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform arCamera;
    public GameObject projectile;
    public float shootForce = 7000.0f;
    public int shootSpeed = 100;
    RaycastHit hit;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward * shootForce);
            Debug.Log("shoot");
        }

    }
}
