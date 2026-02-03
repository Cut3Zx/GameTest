using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;

    public void OnTrgiggerEnter2D(Collider2D collision) => Die();

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position,
        transform.rotation);
        Destroy(explosion, 0.5f);
        Destroy(gameObject);
    } 
    // Start is called before the first frame update
    public void Start() => healthPoint = defaultHealthPoint;
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die(); 
    }
}
