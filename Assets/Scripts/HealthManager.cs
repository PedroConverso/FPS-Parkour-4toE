// En UIManager.cs (queda igual que antes)
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    private float currentMoney = 0f;
    private int maxHealth = 5;

    void Start()
    {
        currentMoney = 0f;
        txtMoney.text = "Money: $0";
        txtHealth.text = $"Vida: {maxHealth}/{maxHealth}";
    }

    public void AddMoney(float amount)
    {
        currentMoney += amount;
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        txtMoney.text = $"Money: ${currentMoney}";
    }

    public void SetMoney(float amount)
    {
        currentMoney = amount;
        UpdateMoneyText();
    }

    public void UpdateHealthPointsText(int healthPoints)
    {
        txtHealth.text = $"Vida: {healthPoints}/{maxHealth}";
    }
}
