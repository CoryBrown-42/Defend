using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
	//player
	public Transform PlayerPOS;
	public int speed = 1;

	//HUD
	public Text scoreText;
	public Text healthText;
	public Text lvlText;
	public Color textColor;

	//Point Handelers
	public int health = 100;
	int maxHealth = 100;
	public int lvl = 0;

	private float score = 0;

	//Pause Menu
	public Canvas PauseMenu;
	//public Transform Player;


	// Use this for initialization
	void Start()
	{
		PauseMenu.enabled = !PauseMenu.enabled;
        Time.timeScale = 1;
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			PauseIt();
		}
	}
	public void AddScore(int points)
	{
		score += points;
		scoreText.text = "Score: " + score + "";
	}

	public void subHealth(int hurt)
	{
		health -= hurt;
		healthText.text = "Health: " + health + "%";
		if (health <= 0)
		{
			RestartScene();
		}
		if (health >= 75)
		{
			healthText.color = Color.green;
		}
		if (health <= 50)
		{
			healthText.color = Color.yellow;
		}
		if (health <= 25)
		{
			healthText.color = Color.red;
		}
        if (health <= 0)
        {
            SceneManager.LoadScene("MobileMenu");
        }

    }
	public void AddHealth(int heal)
	{
		health += heal;
		healthText.text = "Health: " + health + "%";

		if (health >= maxHealth)
		{
			healthText.color = Color.green;
			health = 100;

		}
		if (health >= 75)
		{
			healthText.color = Color.green;
		}
		if (health <= 50)
		{
			healthText.color = Color.yellow;
		}
		if (health <= 25)
		{
			healthText.color = Color.red;
		}
        if (health <= 0)
        {
            SceneManager.LoadScene("MobileMenu");
        }

    }


	public void minusHealth()
	{
		health--;
	}
	public void plusHealth()
	{
		health++;
	}

	void RestartScene()
	{
		SceneManager.LoadScene("MobileTests");
	}
	public void PauseIt()
	{
		PauseMenu.enabled = !PauseMenu.enabled;

		if (PauseMenu.enabled)
		{
			Time.timeScale = 0;
		}
		if (!PauseMenu.enabled)
		{
			Time.timeScale = 1;
		}
	}
	public void MoveRight()
	{
		PlayerPOS.transform.position += transform.right * -speed * Time.deltaTime;
	}
	public void MoveLeft()
	{
		PlayerPOS.transform.position -= transform.right * -speed * Time.deltaTime;
	}
}
