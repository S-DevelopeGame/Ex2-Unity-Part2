using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [Tooltip("Player1 object")]
    [SerializeField] private GameObject player1;

    [Tooltip("Player2 object")]
    [SerializeField] private GameObject player2;

    [Tooltip("the name of the scene that you want to run")]
    [SerializeField] private string restartScene;
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        //  if the two players died - restart the game
        if (player1 == null && player2 == null)
        {
            Debug.Log("Restart");
            SceneManager.LoadScene(restartScene);
        }
       
    }
}
