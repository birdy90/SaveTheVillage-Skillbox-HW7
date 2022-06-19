using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController: MonoBehaviour
{
    public int Amount;
    
    // Start is called before the first frame update
    void Start()
    {
        Amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateFood(int value)
    {
        Amount += value;
    }
}
