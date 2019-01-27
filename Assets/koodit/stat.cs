using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stat : MonoBehaviour
{

    private Image content;

    private float currentFill; //koti-ikava talla hetkella

    public float MyMaxValue {get; set; } //koti-ikavan taysi luku

    private float CurrentValue;

    public float MyCurrentValue
    {
        get
        {
            return CurrentValue;
        }

        set
        {
            if (value > MyMaxValue) //tsekkaa et currentvalue ei mee yli maxvaluen
            {
                CurrentValue = MyMaxValue;

            }
            else if (value < 0)
            {
                CurrentValue = 0;
            }
            else 
            {
                CurrentValue = value; 
            }

            currentFill = CurrentValue / MyMaxValue;
        }


    }


// Use this for initialization
void Start()
{
    content = GetComponent<Image>();
}

// Update is called once per frame
void Update()
{
        content.fillAmount = currentFill;
}

    public void Initialize(float currentValue, float maxValue)
    {
        MyMaxValue = maxValue;
        MyCurrentValue = currentValue;

    }
}


