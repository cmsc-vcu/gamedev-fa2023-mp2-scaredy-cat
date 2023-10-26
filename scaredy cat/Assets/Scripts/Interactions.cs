using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    [SerializeField] private Text startInstructions;
    // Start is called before the first frame update
    void Start()
    {
       startInstructions.text =  "Wellcome traveler!\n Collect the gifts for the moon, and you'll shall pass through the night safely. Don't and face it's wrath!\n BEWARE THE BIRDS!";
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
