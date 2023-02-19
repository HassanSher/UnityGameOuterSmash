
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{

	public static PlatformManager Instance = null;

	[SerializeField]
	GameObject platformPrefab;
	[SerializeField]
	GameObject fries;
	void Awake()
	{

		if (Instance == null)
			Instance = this;
		else if (Instance != this)
			Destroy(gameObject);
	}
	// Use this for initialization
	void Start()
	{
		Instantiate(platformPrefab, new Vector2(-1f, -41f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(-15f, -42f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(-16.5f, -41.5f), platformPrefab.transform.rotation);
		

		Instantiate(platformPrefab, new Vector2(-12f, -39f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(11.9f, -42.5f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(-12.5f, -38f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(13f, -39.5f), platformPrefab.transform.rotation);

		Instantiate(platformPrefab, new Vector2(-14f, -2.5f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(0f, 5.5f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(-7.5f, -4.5f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(0f, -5.5f), platformPrefab.transform.rotation);




		Instantiate(platformPrefab, new Vector2(11f, -41f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(17f, -42f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(1.5f, -41.5f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(16f, -45.5f), platformPrefab.transform.rotation);

		Instantiate(platformPrefab, new Vector2(-13f, -10f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(-11.9f, -15f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(-7.5f, -20f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(7.4f, -25f), platformPrefab.transform.rotation);

		Instantiate(platformPrefab, new Vector2(-14f, -30f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(0f, -35f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(-7.5f, -37f), platformPrefab.transform.rotation);
		Instantiate(platformPrefab, new Vector2(0f, -40f), platformPrefab.transform.rotation);










		Instantiate(fries, new Vector2(-17.5f, -14f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-10f, 0.5f), fries.transform.rotation);
		Instantiate(fries, new Vector2(2.7f, -0.5f), fries.transform.rotation);
		Instantiate(fries, new Vector2(2.7f, -4.5f), fries.transform.rotation);
		Instantiate(fries, new Vector2(0f, -5.5f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-20f, -2.5f), fries.transform.rotation);
		Instantiate(fries, new Vector2(17f, -2f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-16.5f, -3.05f), fries.transform.rotation);
		Instantiate(fries, new Vector2(11f, 2.02f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-10.3f, 1.2f), fries.transform.rotation);
		Instantiate(fries, new Vector2(9.5f, -47f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-11.3f, -43f), fries.transform.rotation);
		Instantiate(fries, new Vector2(10f, 47.2f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-9f, -9f), fries.transform.rotation);
		Instantiate(fries, new Vector2(8.5f, 1.5f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-8f, -40f), fries.transform.rotation);
		Instantiate(fries, new Vector2(2.9f, -45f), fries.transform.rotation);
		Instantiate(fries, new Vector2(-7.5f, -40.5f), fries.transform.rotation);


	}

	IEnumerator SpawnPlatform(Vector2 spawnPosition)
	{
		yield return new WaitForSeconds(7f);
		Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
		yield return new WaitForSeconds(5f);
		Instantiate(fries, spawnPosition, fries.transform.rotation);
	}

	

}