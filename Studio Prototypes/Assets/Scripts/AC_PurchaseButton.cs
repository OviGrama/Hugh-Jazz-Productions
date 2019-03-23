using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_PurchaseButton : MonoBehaviour
{
    // Creates a connection to the AC_SchoolStatsManager and assigns the connection the name schoolStats, so the current money the player has can be collected.
    private AC_SchoolStatsManager schoolStats;
    // Creates a connection to the AC_TierUnlocks.
    private AC_TierUnlocks tierUnlocks;

    // Variable to hold how much the class is worth.
    public int purchasePrice;
    // Variable for whether the class has been brought.
    public bool classBrought;
    // Variable to hold upgrade that is being purchased.
    public Button b_PurchaseButton;
    // Varibale to hold the confirmation button of what is being purchased.
    public Button b_PurchaseConfirmButton;
    // Varibale to hold what has been purchased.
    public Button[] b_PurchasedClassButton;

    // Is it a primary class.
    public bool tier0Class;
    // What type of class is it.
    public bool iqClass;
    public bool fitnessClass;
    public bool superClass;

    // Start is called before the first frame update
    void Start()
    {
        // So the this script doesnt lose the reference to the AC_SchoolStatsManager script. 
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();

        //
        tierUnlocks = GameObject.Find("GameManager").GetComponent<AC_TierUnlocks>();

        // Adds a listener to the confirm button so that when the button is clicked it runs the Purchase function.
        b_PurchaseConfirmButton.onClick.AddListener(Purchase);
    }

    // Function that checks and confirms purchase.
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

            // Activates the all class buttons.
            for (int i = 0; i < b_PurchasedClassButton.Length; i++)
            {
                b_PurchasedClassButton[i].gameObject.SetActive(true);
            }
            
            // Diactivates the purchase button.
            b_PurchaseButton.GetComponent<Button>().interactable = false;
            
            if (tier0Class == true && iqClass == true)
            {
                tierUnlocks.iqBuildingBuyable = true;
            }

            if (tier0Class == true && fitnessClass == true)
            {
                tierUnlocks.fitnessBuildingBuyable = true;

            }

            if (tier0Class == true && superClass == true)
            {
                tierUnlocks.superBuildingBuyable = true;
            }

            tierUnlocks.CanBuy();
            Debug.Log(gameObject);
        }
    }
}
