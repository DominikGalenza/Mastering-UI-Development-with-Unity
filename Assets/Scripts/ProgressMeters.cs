using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressMeters : MonoBehaviour
{
    public uint health;
    public uint totalHealth;
    public float percentHealth;
    public RectTransform healthBar;

    void Update()
    {
        if (health > totalHealth)
        {
            health = totalHealth;
        }

        percentHealth = (float)health / totalHealth;

        healthBar.localScale = new Vector2(percentHealth, 1f);
    }
}
