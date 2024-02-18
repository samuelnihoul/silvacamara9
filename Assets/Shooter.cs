using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform arCamera;
    public GameObject projectile;
    public float shootForce = 7000.0f;
    public int shootSpeed = 100;
    RaycastHit hit;
    // Start is called before the first frame update
    private int counter = 0;
    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == shootSpeed)
        {
            GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward * shootForce);
            Debug.Log("shoot");
            counter = 0;
        }

    }
}
