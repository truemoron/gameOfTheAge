using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
