using UnityEngine;

public class HealSystem : MonoBehaviour
{
    public float healingAmount = 20f;
    public float healingInterval = 5f;

    void Start()
    {
        InvokeRepeating("HealPlayer", 0f, healingInterval);
    }

    void HealPlayer()
    {
        
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            Health playerHealth = player.GetComponent<Health>();

            if (playerHealth != null)
            {
                playerHealth.Heal(healingAmount);
            }
        }
    }
}//tag player zeby dzialalo