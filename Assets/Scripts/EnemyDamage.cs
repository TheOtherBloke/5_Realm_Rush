using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnParticleCollision(GameObject other)
    {
        print("I'm hit!");
    }
}
