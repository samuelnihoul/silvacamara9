using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject shoot;

    // Start is called before the first frame update
    void Start()
    {
        shoot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        shoot.SetActive(true);
    }
}
