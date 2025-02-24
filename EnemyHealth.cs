using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthAbstract
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage();
        }
    }

    public new void TakeDamage() { base.TakeDamage(_damage); Debug.Log("Ударил игрок"); }
    public new void Kill() { base.Kill(); }
}
