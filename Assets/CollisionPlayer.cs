using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionPlayer : MonoBehaviour
{
    [Tooltip("Array triggers of tag objects")]
    [SerializeField] private string[] triggeringTag;

    [Tooltip("Array of images lives")]
    [SerializeField] private Image[] lives;

    [Tooltip("Array of images lives")]
    [SerializeField] NumberField scoreField;

    [Tooltip("the number of points to add everytime")]
    [SerializeField] int pointsToAdd;

    [Tooltip("the name of the scene")]
    [SerializeField] string sceneName;

    //save the start location
    private Vector3 startLocation;

    //number of the current lives
    private int liveRemaining;

    // Start is called before the first frame update
    void Start()
    {
        liveRemaining = lives.Length;
        startLocation = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag[0] && enabled) // Collide with Cars
        {
            //Debug.Log(liveRemaining);
            liveRemaining -= 1; // update your number lives-1
            lives[liveRemaining].enabled = false; // update your images lives down 
                                                  // Debug.Log(liveRemaining);
            transform.position = startLocation; // back to your old location
            //Debug.Log("Location");
            if (liveRemaining == 0) // destroy object after you have 0 lives
                Destroy(this.gameObject);
        }
        else if (other.tag == triggeringTag[1] && enabled) // Collide with Walkside
        {
            Debug.Log("Becareful enemies in your space");
        }

        else if (other.tag == triggeringTag[2] && enabled && this.tag == "Player1") // Collide between fly1 to player1
        {
            Destroy(other.gameObject);
            scoreField.AddNumber(pointsToAdd); // add points to player

        }

        else if (other.tag == triggeringTag[3] && enabled && this.tag == "Player2") // Collide between fly2 to player2
        {
            Destroy(other.gameObject);
            scoreField.AddNumber(pointsToAdd); // add points to player

        }

        else if (other.tag == triggeringTag[4] && enabled && this.tag == "Player1") // collide with Door that say you won game
        {
            Object.DontDestroyOnLoad(gameObject); //Don't destroy the player that won
            WinnerPlayer();
            Debug.Log("Door1");
        }

        else if (other.tag == triggeringTag[5] && enabled && this.tag == "Player2")
        {
            Object.DontDestroyOnLoad(gameObject); //Don't destroy the player that won
            WinnerPlayer();
            Debug.Log("Door2");
        }

    }

    private void WinnerPlayer()
    {
        Object.DontDestroyOnLoad(gameObject); //Don't destroy the player that won
        //Destroy(GetComponent<MovementPlayer>()); // remove component MovementPlayer
        SceneManager.LoadScene(sceneName); // reload "Won" scene
        transform.position = Vector3.zero+Vector3.up*3; // locate the winner in the center
    }



}
