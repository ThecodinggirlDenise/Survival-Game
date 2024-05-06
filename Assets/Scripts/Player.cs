using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float health;
    public Slider HealthSlider;
    public float Hunger;
    public Slider HungerSlider;
    public float Thirst;
    public Slider ThirstSlider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HealthSlider.value = health;
        HungerSlider.value = Hunger;
        ThirstSlider.value = Thirst;

        Hunger -= 0.05f;
        Thirst -= 0.1f;


        if (Hunger <= 0)
        {
            health -= 0.01f;

        }


        if (Thirst <= 0)
        {
            health -= 0.01f;

        }
    }

}
