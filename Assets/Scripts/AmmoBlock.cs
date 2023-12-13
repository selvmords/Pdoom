using UnityEngine;

public class AmmoBlock : MonoBehaviour
{
    public int ammoAmount = 10; // Ilo�� amunicji do dodania

    void OnTriggerEnter(Collider other)
    {
        // Sprawd�, czy kolizja dotyczy gracza
        if (other.CompareTag("Player"))
        {
            // Dodaj amunicj� do gracza
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
