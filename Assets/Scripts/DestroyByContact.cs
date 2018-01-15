using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameManager gameController;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameManager>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Boundary") && !other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            if (explosion != null)
            {
                Instantiate(explosion, transform.position, transform.rotation);
            }
            if (other.name == "Player")
            {
                gameController.GameOver();
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            }
            gameController.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
