using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour {

    public Transform redPlayer;
    public Text distanceText;
    // Update is called once per frame
    void Update () {
        distanceText.text = redPlayer.position.z.ToString("0"); 

        if(redPlayer.transform.position.y < 0)
        {
            distanceText.text = "Game Over";
        }
	}
}
