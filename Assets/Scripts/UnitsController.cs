using UnityEngine;

public class UnitsController: MonoBehaviour
{
    public string title;
    public int amount;
    public int foodUpdateInterval;
    public int foodUpdateAmount;

    public FoodController foodController;

    private float _lastFoodUpdate = 0f;

    void Update()
    {
        if (Time.time - _lastFoodUpdate >= foodUpdateInterval)
        {
            _lastFoodUpdate = Time.time;
            foodController.UpdateFood(foodUpdateAmount);
        }
    }
}