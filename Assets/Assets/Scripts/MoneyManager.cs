// En MoneyManager.cs, reemplaza cualquier llamada a UpdateMoneyText por AddMoney o SetMoney, ejemplo:

using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public UIManager uiManager;

    void Start()
    {
        // Inicialmente ponemos dinero en 0 (opcional, porque UIManager ya lo hace)
        uiManager.SetMoney(0);
    }

    void SomeMethodWhereYouAddMoney()
    {
        // En vez de llamar a uiManager.UpdateMoneyText(...), llamá:
        uiManager.AddMoney(10); // Suma 10 al dinero actual y actualiza la UI
    }
}
