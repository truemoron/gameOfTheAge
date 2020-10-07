using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerTr;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerMovement>().gameIsActive == true)
        {
            scoreText.text = playerTr.position.x.ToString("0");
        }
        
    }
}
