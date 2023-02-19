using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth = 100;
	public float timeLeft = 1.0f;
	public HealthBar healthBar;
	
	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		
	}

	// Update is called once per frame
	void Update()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0)
		{
			TakeDamage(5);
			timeLeft = 0.5f;
		}
		if (currentHealth <= 50)
        {
			Destroy(gameObject);
			SceneManager.LoadScene("Restart");
		}
		
	}
	void OnCollisionEnter2D(Collision2D collision2D)
	{
		if (collision2D.gameObject.tag == "HP")
		{
			currentHealth = 100;


		}
		if (collision2D.gameObject.tag == "Points")
		{
			currentHealth = 100;


		}
		if (collision2D.gameObject.tag == "Points2")
		{
			TakeDamage(-20);


		}
		if (collision2D.gameObject.tag == "BN")
		{
			TakeDamage(-20);


		}
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
