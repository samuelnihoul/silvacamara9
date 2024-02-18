using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Zombie")
        {
            Destroy(collision.transform.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        }
    }
}
