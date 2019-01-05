
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerMovement movement;//assign it in inspector tab.

    public void EndGame()
    {
        movement.enabled = false;
    }
}
