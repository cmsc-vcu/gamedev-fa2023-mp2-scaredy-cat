using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    private int gifts = 0;

    [SerializeField] private Text giftsText;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
         if(other.gameObject.CompareTag("Gifts"))
        {
            Destroy(other.gameObject);
            gifts++;
            giftsText.text = "Gifts: " + gifts;
        }
    }
}
