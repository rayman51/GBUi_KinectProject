using UnityEngine;

public class Bricks : MonoBehaviour
{

    public GameObject brickParticle;

    void OnCollisionEnter(Collision other)
    {   // identifies the rotations
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        // applies condition of brick being destroyed
        GM.instance.DestroyBrick();
        // destroys gameObject
        Destroy(gameObject);
    }
}

