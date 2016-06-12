using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EarthHit : MonoBehaviour {

    public Text livesText;
    public GameObject gameOverWindow;
    public GameObject AsteroidGenerator;
    public int lives = 3;

    void Start()
    {
        livesText.text = lives.ToString();
    }

    void OnTriggerEnter(Collider col)
    {
        lives--;
        Destroy(col.gameObject);

        if(lives <= 0)
        {
            gameOverWindow.SetActive(true);
            AsteroidGenerator.GetComponent<AsteroidGenerator>().EndGame();
        }
    }

    void Update()
    {
        livesText.text = lives.ToString();
    }


}
