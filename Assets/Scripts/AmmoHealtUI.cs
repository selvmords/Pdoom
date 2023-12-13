using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoHealtUI : MonoBehaviour
{
    public TextMeshProUGUI ammoText;
    public GunData gunData;

    void Update()
    {
        if(gunData != null)
        {
            ammoText.text = "Ammo: " + gunData.currentAmmo.ToString();
        }
        else
        {
            ammoText.text = "Dodaj GunData";
        }
    }
}
