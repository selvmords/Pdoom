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
        // Tutaj mo¿esz dodaæ logikê, która ma zostaæ wykonana po œmierci gracza
        Debug.Log("Gracz zgin¹³!");
    }
}
//To by trzeba by³o dodaæ do komponentu gracz, to by go leczy³o potem ze skryptu heal