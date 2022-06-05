using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damageAmount = 2;

    public void OnCollisionEnter(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<Health>();

        if (enemyHealth)
        {
            //do damage
            enemyHealth.TakeDamage(damageAmount);
        }
    }
}
