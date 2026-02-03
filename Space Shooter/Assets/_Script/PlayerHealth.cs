using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        // Custom behavior for player death can be added here
        base.Die();
    }
}
