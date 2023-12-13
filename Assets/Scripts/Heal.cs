using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    
    public float rotationSpeed = 5f;

    void Update()
    {
        RotateTowardsPlayer();
    }

    void RotateTowardsPlayer()
    {
        // ZnajdŸ gracza (za³ó¿my, ¿e gracz ma tag "Player")
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // Oblicz kierunek do gracza
            Vector3 direction = player.transform.position - transform.position;

            // Oblicz kierunek obracania obiektu
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);

            // Obróæ obiekt w kierunku gracza z okreœlon¹ prêdkoœci¹
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
//ogólne leczenie, nic specjalnego