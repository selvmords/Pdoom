using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(float healAmount)
    {
        currentHealth = Mathf.Min(currentHealth + healAmount, maxHealth);
    }

    void Die()
    {
        // Tutaj mo�esz doda� logik�, kt�ra ma zosta� wykonana po �mierci gracza
        Debug.Log("Gracz zgin��!");
    }
}
//To by trzeba by�o doda� do komponentu gracz, to by go leczy�o potem ze skryptu heal