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
        // Znajd� gracza (za��my, �e gracz ma tag "Player")
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // Oblicz kierunek do gracza
            Vector3 direction = player.transform.position - transform.position;

            // Oblicz kierunek obracania obiektu
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);

            // Obr�� obiekt w kierunku gracza z okre�lon� pr�dko�ci�
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
//og�lne leczenie, nic specjalnego