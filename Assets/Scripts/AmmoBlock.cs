using UnityEngine;

public class AmmoBlock : MonoBehaviour
{
    public int ammoAmount = 10; // Iloœæ amunicji do dodania

    void OnTriggerEnter(Collider other)
    {
        // SprawdŸ, czy kolizja dotyczy gracza
        if (other.CompareTag("Player"))
        {
            // Dodaj amunicjê do gracza
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.AddAmmo(ammoAmount);

                // Zniszcz blok amunicji po dodaniu amunicji
                Destroy(gameObject);
            }
        }
    }
}
