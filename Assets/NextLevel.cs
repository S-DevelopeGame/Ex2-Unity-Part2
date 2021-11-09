using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [Tooltip("the score of the player")]
    [SerializeField] NumberField scoreField;

    [Tooltip("the number score for open the door")]
    [SerializeField] private int openTheDoor;

    [Tooltip("the door object")]
    [SerializeField] GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(false); // the door is not active because you need to get the score for open the door
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreField.GetNumber() == openTheDoor)
            door.SetActive(true);
    }       
}
