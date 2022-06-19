using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CooldownButton : MonoBehaviour
{
    public int cooldownDuration;
    public bool isLocked;
    public Sprite iconSprite;

    public GameObject cooldownPanel;
    public Image buttonImage;
    public Image cooldownIndicator;
    public TMP_Text cooldownText;

    private float _lastClickTime;

    public bool IsClickable => !isLocked && Time.time - _lastClickTime >= cooldownDuration;
    
    // Start is called before the first frame update
    void Start()
    {
        var a = Mathf.Epsilon;
        cooldownDuration = 0;
        _lastClickTime = -cooldownDuration;
        buttonImage.sprite = iconSprite;
    }

    public void OnClick()
    {
        if (!IsClickable) return;
        
        _lastClickTime = Time.time;
        cooldownPanel.SetActive(true);
        UpdateCooldown();
    }

    void UpdateCooldown()
    {
        var elapsedTime = Time.time - _lastClickTime;
        cooldownIndicator.fillAmount = 1 - elapsedTime / cooldownDuration;
        cooldownText.text = MathF.Ceiling(elapsedTime).ToString(CultureInfo.InvariantCulture);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - _lastClickTime >= cooldownDuration)
        {
            cooldownPanel.SetActive(false);
        }
    }
}
