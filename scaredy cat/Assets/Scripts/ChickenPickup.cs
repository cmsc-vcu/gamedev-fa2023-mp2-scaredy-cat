using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenPickup : MonoBehaviour
{
    private int chicken = 0;
    // Start is called before the first frame update

    [SerializeField] private Text chickenText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Chicken"))
        {
            Destroy(other.gameObject);
            chicken++;
            chickenText.text = "Chickens: " + chicken;
        }
    }
}
