using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_PurchaseButton : MonoBehaviour
{
    // Creates a connection to the AC_SchoolStatsManager and assigns the connection the name schoolStats, so the current money the player has can be collected.
    private AC_SchoolStatsManager schoolStats;
    // Variable to hold how much the class is worth.
    public int purchasePrice;
    // Variable for whether the class has been brought.
    public bool classBrought;
    // Variable to hold upgrade that is being purchased.
    public Button b_PurchaseButton;
    // Varibale to hold the confirmation button of what is being purchased.
    public Button b_PurchaseConfirmButton;
    // Varibale to hold what has been purchased.
    public Button b_PurchasedClassButton;
    

    // Start is called before the first frame update
    void Start()
    {
        //
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();

        //
        b_PurchaseConfirmButton.onClick.AddListener(Purchase);
    }

    //
    void Purchase()
    {
        // Checks the player has enough money to purchase the class.
        if (schoolStats.currentMoney - purchasePrice >= 0)
        {
            //Subtracts class price from current money amount.
            schoolStats.currentMoney -= purchasePrice;

            // Run money stat update.
            schoolStats.StatsUpdate();

            // Turns associated brought variable to true.
            classBrought = true;

            // Activates the class button.
            b_PurchasedClassButton.gameObject.SetActive(true);

            // Diactivates the purchase button.
            b_PurchaseButton.GetComponent<Button>().interactable = false;
        }
    }

}
