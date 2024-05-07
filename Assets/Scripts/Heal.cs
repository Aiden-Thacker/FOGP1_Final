using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.Helper;

public class Heal : MonoBehaviour
{
    public string tagToHeal;
    public int healed = 5;
    void OnTriggerEnter(Collider _other)
    {
        Health health = _other.GetComponent<Health>();

        if (health && _other.tag == tagToHeal)
        {
            Debug.Log("Spell Has Hit");
            health.Heal(healed);
        }
    }
}
