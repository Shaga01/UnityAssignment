using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class BirdControlelr : MonoBehaviour
{
    [SerializeField] SplineAnimate mySplineAnimate;
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject fireEffectPrefab;
    [SerializeField] GameObject hitEffect;

    private void Awake()
    {
        mySplineAnimate.Container = SplineHolder.Instance.GetRandomSpline();
       
    }
    private void Update()
    {
        CheckIfOutOfBounds();
    }

    private void CheckIfOutOfBounds()
    {
        // Get the screen boundaries in world space
        Vector3 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        // Check if the bird's position is greater than the right side of the screen
        if (transform.position.x -1 > screenBounds.x)
        {
            // Bird is out of the screen on the right side, destroy it
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }
    public void OnHitBird(int damage)
    {
        //Decrease Health
        //Adjust HealthBar
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
            Destroy(Instantiate(hitEffect, transform.position, Quaternion.identity),1);


        if (currentHealth <= 0) {
            Destroy(Instantiate(fireEffectPrefab, transform.position, Quaternion.identity),1);
            Score.Instance.IncrementScore();

            Destroy(gameObject);
        }


        //Hit Effect
        //Death effect
    }
}
